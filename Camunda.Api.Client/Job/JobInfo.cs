using System;

namespace Camunda.Api.Client.Job
{
    public class JobInfo
    {
        /// <summary>
        /// The id of the job.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the associated job definition.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// The id of the process instance which execution created the job.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the process definition which this job belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The key of the process definition which this job belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The specific execution id on which the job was created.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The message of the exception that occurred, the last time the job was executed. Is null when no exception occurred.
        /// </summary>
        public string ExceptionMessage { get; set; }
        /// <summary>
        /// The number of retries this job has left.
        /// </summary>
        public int Retries { get; set; }
        /// <summary>
        /// The date on which this job is supposed to be processed.
        /// </summary>
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// A flag indicating whether the job is suspended or not.
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// The job's priority for execution.
        /// </summary>
        public long Priority { get; set; }
        /// <summary>
        /// The id of the tenant which this job belongs to.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Id;
    }
}
