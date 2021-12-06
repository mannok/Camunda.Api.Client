using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Job
{
    public class JobQuery : SortableQuery<JobQuerySorting, JobQuery>
    {
        /// <summary>
        /// Only select jobs which exist for an activity with the given id.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// Filter by job id.
        /// </summary>
        public string JobId { get; set; }
        /// <summary>
        /// Only select jobs which exist for the given execution.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Only select jobs which exist for the given process instance.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the process definition the jobs run on.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Filter by the key of the process definition the jobs run on.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Only select jobs which have retries left. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithRetriesLeft { get; set; }
        /// <summary>
        /// Only select jobs which are executable, ie. retries > 0 and due date is null or due date is in the past. Value may only be true, as
        /// </summary>
        public bool Executable { get; set; }
        /// <summary>
        /// Only select jobs that are timers. Cannot be used together with messages. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Timers { get; set; }
        /// <summary>
        /// Only select jobs that are messages. Cannot be used together with timers. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Messages { get; set; }
        /// <summary>
        /// Only select jobs that failed due to an exception. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithException { get; set; }
        /// <summary>
        /// Only select jobs that failed due to an exception with the given message.
        /// </summary>
        public string ExceptionMessage { get; set; }
        /// <summary>
        /// Only select jobs which have no retries left. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool NoRetriesLeft { get; set; }
        /// <summary>
        /// Only include active jobs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Only include suspended jobs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// Only include jobs with a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long? PriorityHigherThanOrEquals { get; set; }
        /// <summary>
        /// Only include jobs with a priority lower than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long? PriorityLowerThanOrEquals { get; set; }
        /// <summary>
        /// Only select jobs which exist for the given job definition.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// Only include jobs which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Only include jobs which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId { get; set; }
        /// <summary>
        /// Include jobs which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as
        /// </summary>
        public bool IncludeJobsWithoutTenantId { get; set; }
        /// <summary>
        /// Only select jobs where the due date is lower or higher than the given date.
        /// </summary>
        public List<ConditionQueryParameter> DueDates { get; set; } = new List<ConditionQueryParameter>();
    }

    public enum JobQuerySorting
    {
        JobId,
        ExecutionId,
        ProcessInstanceId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        JobRetries,
        JobDueDate,
        JobPriority,
        TenantId
    }
}
