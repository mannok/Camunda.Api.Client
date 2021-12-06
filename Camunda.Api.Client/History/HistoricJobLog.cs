using System;

namespace Camunda.Api.Client.History
{
    public class HistoricJobLog
    {
        /// <summary>
        /// The id of the log entry.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The time when the log entry has been written.
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// The id of the associated job.
        /// </summary>
        public string JobId { get; set; }
        /// <summary>
        /// The date on which the associated job is supposed to be processed.
        /// </summary>
        public DateTime JobDueDate { get; set; }
        /// <summary>
        /// The number of retries the associated job has left.
        /// </summary>
        public int JobRetries { get; set; }
        /// <summary>
        /// The execution priority the job had when the log entry was created.
        /// </summary>
        public long JobPriority { get; set; }
        /// <summary>
        /// The message of the exception that occurred by executing the associated job.
        /// </summary>
        public string JobExceptionMessage { get; set; }
        /// <summary>
        /// The id of the job definition on which the associated job was created.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// The job definition type of the associated job.
        /// </summary>
        public string JobDefinitionType { get; set; }
        /// <summary>
        /// The job definition configuration type of the associated job.
        /// </summary>
        public string JobDefinitionConfiguration { get; set; }
        /// <summary>
        /// The id of the activity on which the associated job was created.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// The execution id on which the associated job was created.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The id of the process instance on which the associated job was created.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The key of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The id of the deployment which the associated job belongs to.
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// The id of the tenant that this historic job log entry belongs to.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// A flag indicating whether this log represents the creation of the associated job.
        /// </summary>
        public bool CreationLog { get; set; }
        /// <summary>
        /// A flag indicating whether this log represents the failed execution of the associated job.
        /// </summary>
        public bool FailureLog { get; set; }
        /// <summary>
        /// A flag indicating whether this log represents the successful execution of the associated job.
        /// </summary>
        public bool SuccessLog { get; set; }
        /// <summary>
        /// A flag indicating whether this log represents the deletion of the associated job.
        /// </summary>
        public bool DeletionLog { get; set; }

        public override string ToString() => Id;
    }
}
