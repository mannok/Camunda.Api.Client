using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Camunda.Api.Client.ExternalTask;
using Common.Logging;

namespace Camunda.Api.Client.Worker
{
    public class ExternalTaskListener
    {
        private ILog logger = LogManager.GetLogger(typeof(ExternalTaskListener));

        private string workerId = Guid.NewGuid().ToString();

        private long pollingIntervalInMilliseconds; // every 50 milliseconds
        private int maxDegreeOfParallelism;

        private long lockDurationInMilliseconds = 1 * 60 * 1000; // 1 minute
        private Timer taskQueryTimer;

        private ExternalTaskService externalTaskService;
        private IEnumerable<ExternalTaskWorkerInfo> workerInfos;

        public ExternalTaskListener(ExternalTaskService externalTaskService, IEnumerable<ExternalTaskWorkerInfo> workerInfos, int pollingIntervalInMilliseconds = 50, int maxDegreeOfParallelism = 32)
        {
            this.externalTaskService = externalTaskService;
            this.workerInfos = workerInfos;
            this.pollingIntervalInMilliseconds = pollingIntervalInMilliseconds;
            this.maxDegreeOfParallelism = maxDegreeOfParallelism;
        }

        public void StartWork()
        {
            taskQueryTimer = new Timer(_ => DoPolling().Wait(), null, pollingIntervalInMilliseconds, Timeout.Infinite);
        }

        public void StopWork()
        {
            this.taskQueryTimer.Dispose();
            this.taskQueryTimer = null;
        }

        public void Dispose()
        {
            if (this.taskQueryTimer != null)
            {
                this.taskQueryTimer.Dispose();
            }
        }

        public async Task DoPolling()
        {
            // Query External Tasks
            try
            {
                var camundaPendingTasks = await externalTaskService.Query().List();

                await Task.WhenAll(camundaPendingTasks.Select(async camundaPendingTask =>
                {
                    try
                    {
                        // get the assembly in the list
                        if (!string.IsNullOrEmpty(camundaPendingTask.Id) && !string.IsNullOrEmpty(camundaPendingTask.TopicName))
                        {
                            // find the matched assembly
                            var workers = workerInfos.Where(x => x.ProcessId == camundaPendingTask.ProcessDefinitionKey && x.ActivityId == camundaPendingTask.ActivityId);

                            if (workers.Count() > 1)
                            {
                                throw new Exception("More than one adapter found in the assembly");
                            }

                            var worker = workers.Single();
                            var tasks = await externalTaskService.FetchAndLock(new FetchExternalTasks()
                            {
                                WorkerId = workerId,
                                MaxTasks = 1,
                                Topics = new List<FetchExternalTaskTopic>() {
                                    new FetchExternalTaskTopic(camundaPendingTask.TopicName, lockDurationInMilliseconds) { Variables = worker.VariablesToFetch }
                                }
                            });

                            if (tasks.Count() > 1)
                            {
                                throw new Exception("More than one task return from Camunda");
                            }
                            else if (tasks.Count() <= 1)
                            {
                                logger.Warn(string.Format(@"another worker is locked for the task id {0}.", camundaPendingTask.Id));
                            }

                            await Execute(tasks.Single(), worker);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }).ToArray());
            }
            catch (Exception ex)
            {
                // Most probably server is not running or request is invalid
                Console.WriteLine(ex.Message);
                logger.Fatal(ex);
            }

            // schedule next run (if not stopped in between)
            if (taskQueryTimer != null)
            {
                taskQueryTimer.Change(TimeSpan.FromMilliseconds(pollingIntervalInMilliseconds), TimeSpan.FromMilliseconds(Timeout.Infinite));
            }
        }

        private async Task Execute(LockedExternalTask externalTask, ExternalTaskWorkerInfo taskWorkerInfo)
        {
            logger.Info(string.Format(@"Execute external task for process id {0} and activity id {1}", taskWorkerInfo.ProcessId, taskWorkerInfo.ActivityId));
            try
            {
                var resultVariables = taskWorkerInfo.TaskAdapter.Execute(externalTask);
                logger.Info($"...finished External Task {externalTask.Id}");
                await externalTaskService[externalTask.Id].Complete(new CompleteExternalTask()
                {
                    WorkerId = workerId,
                    Variables = resultVariables
                });
            }
            catch (UnrecoverableBusinessErrorException ex)
            {
                logger.Warn($"...failed with business error code from External Task  {externalTask.Id}", ex);
                await externalTaskService[externalTask.Id].HandleBpmnError(new ExternalTaskBpmnError()
                {
                    WorkerId = workerId,
                    ErrorCode = ex.BusinessErrorCode,
                    ErrorMessage = ex.Message
                });
            }
            catch (Exception ex)
            {
                logger.Error($"...failed External Task  {externalTask.Id}", ex);
                var retriesLeft = taskWorkerInfo.Retries; // start with default
                if (externalTask.Retries.HasValue) // or decrement if retries are already set
                {
                    retriesLeft = externalTask.Retries.Value - 1;
                }
                await externalTaskService[externalTask.Id].HandleFailure(new ExternalTaskFailure()
                {
                    WorkerId = workerId,
                    Retries = retriesLeft,
                    RetryTimeout = taskWorkerInfo.RetryTimeout,
                    ErrorMessage = ex.Message
                });
            }
        }

    }
}
