using Camunda.Api.Client.ExternalTask;
using System;
using System.Collections.Generic;
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

        public void DoPolling()
        {
            // Query External Tasks
            try
            {
                var tasks = externalTaskService.FetchAndLock(new FetchExternalTasks()
                {
                    WorkerId = workerId,
                    MaxTasks = maxTasksToFetchAtOnce,
                    Topics = new List<FetchExternalTaskTopic>() {
                        new FetchExternalTaskTopic(taskWorkerInfo.TopicName,lockDurationInMilliseconds) { Variables = taskWorkerInfo.VariablesToFetch }
                    }
                }).Result;

                // run them in parallel with a max degree of parallelism
                Parallel.ForEach(
                    tasks,
                    new ParallelOptions { MaxDegreeOfParallelism = this.maxDegreeOfParallelism },
                    externalTask => Execute(externalTask)
                );
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

        private void Execute(LockedExternalTask externalTask)
        {
            Console.WriteLine($"Execute External Task from topic '{taskWorkerInfo.TopicName}': {externalTask}...");
            try
            {
                var variables = taskWorkerInfo.TaskAdapter.Execute(externalTask);
                Console.WriteLine($"...finished External Task {externalTask.Id}");
                externalTaskService[externalTask.Id].Complete(new CompleteExternalTask()
                {
                    WorkerId = workerId,
                    Variables = variables
                }).Wait();
            }
            catch (UnrecoverableBusinessErrorException ex)
            {
                Console.WriteLine($"...failed with business error code from External Task  {externalTask.Id}");
                externalTaskService[externalTask.Id].HandleBpmnError(new ExternalTaskBpmnError()
                {
                    WorkerId = workerId,
                    ErrorCode = ex.BusinessErrorCode,
                    ErrorMessage = ex.Message
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"...failed External Task  {externalTask.Id}");
                var retriesLeft = taskWorkerInfo.Retries; // start with default
                if (externalTask.Retries.HasValue) // or decrement if retries are already set
                {
                    retriesLeft = externalTask.Retries.Value - 1;
                }
                externalTaskService[externalTask.Id].HandleFailure(new ExternalTaskFailure()
                {
                    WorkerId = workerId,
                    Retries = retriesLeft,
                    RetryTimeout = taskWorkerInfo.RetryTimeout,
                    ErrorMessage = ex.Message
                }).Wait();
            }
        }

        public void StartWork()
        {
            this.taskQueryTimer = new Timer(_ => DoPolling(), null, pollingIntervalInMilliseconds, Timeout.Infinite);
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
    }
}
