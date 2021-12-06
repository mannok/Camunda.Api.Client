using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskQuery : SortableQuery<ExternalTaskSorting, ExternalTaskQuery>
    {
        /// <summary>
        /// Filter by an external task's id.
        /// </summary>
        public string ExternalTaskId { get; set; }
        /// <summary>
        /// Filter by the id of the activity that an external task is created for.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// Restrict to external tasks that have a lock that expires before a given date.
        /// </summary>
        public DateTime? LockExpirationBefore { get; set; }
        /// <summary>
        /// Restrict to external tasks that have a lock that expires after a given date.
        /// </summary>
        public DateTime? LockExpirationAfter { get; set; }
        /// <summary>
        /// Filter by an external task topic.
        /// </summary>
        public string TopicName { get; set; }
        /// <summary>
        /// Only include external tasks that are currently locked (i.e. they have a lock time and it has not expired). Value may only be true, as false matches any external task.
        /// </summary>
        public bool? Locked { get; set; }
        /// <summary>
        /// Only include external tasks that are currently not locked (i.e. they have no lock or it has expired). Value may only be true, as false matches any external task.
        /// </summary>
        public bool? NotLocked { get; set; }
        /// <summary>
        /// Filter by the id of the execution that an external task belongs to.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Filter by the id of the process instance that an external task belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the process definition that an external task belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Only include active tasks. Value may only be true, as false matches any external task.
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Only include suspended tasks. Value may only be true, as false matches any external task.
        /// </summary>
        public bool? Suspended { get; set; }
        /// <summary>
        /// Only include external tasks that have a positive (> 0) number of retries (or null). Value may only be true, as false matches any external task.
        /// </summary>
        public bool? WithRetriesLeft { get; set; }
        /// <summary>
        /// Only include external tasks that have 0 retries. Value may only be true, as false matches any external task.
        /// </summary>
        public bool? NoRetriesLeft { get; set; }
        /// <summary>
        /// Filter by the id of the worker that the task was most recently locked by.
        /// </summary>
        public string WorkerId { get; set; }
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. An external task must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Only include jobs with a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long? PriorityHigherThanOrEquals { get; set; }
        /// <summary>
        /// Only include jobs with a priority lower than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long? PriorityLowerThanOrEquals { get; set; }
    }

    public enum ExternalTaskSorting
    {
        Id,
        LockExpirationTime,
        ProcessInstanceId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        TaskPriority,
        TenantId
    }
}
