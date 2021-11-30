using Camunda.Api.Client.ExternalTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Worker
{
    public class ExternalTaskWorker : IDisposable
    {
        private string workerId = Guid.NewGuid().ToString(); // TODO: Make configurable

        private Timer taskQueryTimer;
        private long pollingIntervalInMilliseconds = 50; // every 50 milliseconds
        private int maxDegreeOfParallelism = 2;
        private int maxTasksToFetchAtOnce = 10;
        private long lockDurationInMilliseconds = 1 * 60 * 1000; // 1 minute
        private ExternalTaskService externalTaskService;
        private ExternalTaskTopicWorkerInfo taskWorkerInfo;

        public ExternalTaskWorker(ExternalTaskService externalTaskService, ExternalTaskTopicWorkerInfo taskWorkerInfo)
        {
            this.externalTaskService = externalTaskService;
            this.taskWorkerInfo = taskWorkerInfo;
        }

        public async Task DoPolling()
        {
            // Query External Tasks
            try
            {
                var tasks = await externalTaskService.FetchAndLock(new FetchExternalTasks()
                {
                    WorkerId = workerId,
                    MaxTasks = maxTasksToFetchAtOnce,
                    Topics = new List<FetchExternalTaskTopic>() {
                        new FetchExternalTaskTopic(taskWorkerInfo.TopicName,lockDurationInMilliseconds) { Variables = taskWorkerInfo.VariablesToFetch }
                    }
                });

                await Task.WhenAll(tasks.Select(externalTask => Execute(externalTask)).ToArray());
            }
            catch (Exception ex)
            {
                // Most probably server is not running or request is invalid
                Console.WriteLine(ex.Message);
            }

            // schedule next run (if not stopped in between)
            if (taskQueryTimer != null)
            {
                taskQueryTimer.Change(TimeSpan.FromMilliseconds(50), TimeSpan.FromMilliseconds(Timeout.Infinite));
            }
        }

        private async Task Execute(LockedExternalTask externalTask)
        {
            Console.WriteLine($"Execute External Task from topic '{taskWorkerInfo.TopicName}': {externalTask}...");
            try
            {
                var variables = taskWorkerInfo.TaskAdapter.Execute(externalTask);
                Console.WriteLine($"...finished External Task {externalTask.Id}");
                await externalTaskService[externalTask.Id].Complete(new CompleteExternalTask()
                {
                    WorkerId = workerId,
                    Variables = variables
                });
            }
            catch (UnrecoverableBusinessErrorException ex)
            {
                Console.WriteLine($"...failed with business error code from External Task  {externalTask.Id}");
                await externalTaskService[externalTask.Id].HandleBpmnError(new ExternalTaskBpmnError()
                {
                    WorkerId = workerId,
                    ErrorCode = ex.BusinessErrorCode,
                    ErrorMessage = ex.Message
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"...failed External Task  {externalTask.Id}");
                await externalTaskService[externalTask.Id].HandleFailure(new ExternalTaskFailure()
                {
                    WorkerId = workerId,
                    Retries = externalTask.Retries.HasValue ? externalTask.Retries.Value - 1 : taskWorkerInfo.Retries,
                    RetryTimeout = taskWorkerInfo.RetryTimeout,
                    ErrorMessage = ex.Message
                });
            }
        }

        public void StartWork()
        {
            taskQueryTimer = new Timer(_ => DoPolling().Wait(), null, pollingIntervalInMilliseconds, Timeout.Infinite);
        }

        public void StopWork()
        {
            taskQueryTimer.Dispose();
            taskQueryTimer = null;
        }

        public void Dispose()
        {
            if (taskQueryTimer != null)
            {
                taskQueryTimer.Dispose();
            }
        }
    }
}
