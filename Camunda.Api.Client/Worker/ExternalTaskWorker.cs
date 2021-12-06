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

        private CancellationTokenSource pollingCancellationTokenSource;
        private int pollingIntervalInMilliseconds = 50; // every 50 milliseconds
        private int maxDegreeOfParallelism;
        private int maxTasksToFetchAtOnce = 10;
        private long lockDurationInMilliseconds = 1 * 60 * 1000; // 1 minute
        private ExternalTaskService externalTaskService;
        private ExternalTaskTopicWorkerInfo taskWorkerInfo;

        public ExternalTaskWorker(ExternalTaskService externalTaskService, ExternalTaskTopicWorkerInfo taskWorkerInfo, int maxDegreeOfParallelism = 2)
        {
            this.externalTaskService = externalTaskService;
            this.taskWorkerInfo = taskWorkerInfo;
            this.maxDegreeOfParallelism = maxDegreeOfParallelism;
        }

        public async Task DoPolling()
        {
            if (pollingCancellationTokenSource?.Token.IsCancellationRequested ?? true) return;

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

                Parallel.ForEach(
                    tasks, 
                    new ParallelOptions() { MaxDegreeOfParallelism = maxDegreeOfParallelism }, 
                    externalTask => Execute(externalTask).Wait()
                );
            }
            catch (Exception ex)
            {
                // Most probably server is not running or request is invalid
                Console.WriteLine(ex.Message);
            }

            await Task.Delay(pollingIntervalInMilliseconds);
            await DoPolling();
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
            if (pollingCancellationTokenSource != null) throw new Exception("work has been started already");

            pollingCancellationTokenSource = new CancellationTokenSource();

            DoPolling().ContinueWith(_ => { });
        }

        public void StopWork()
        {
            if (pollingCancellationTokenSource == null) throw new Exception("no work has been started before");

            pollingCancellationTokenSource.Cancel();
            pollingCancellationTokenSource.Dispose();
            pollingCancellationTokenSource = null;
        }

        public void Dispose()
        {
            pollingCancellationTokenSource?.Cancel();
            pollingCancellationTokenSource?.Dispose();
        }
    }
}
