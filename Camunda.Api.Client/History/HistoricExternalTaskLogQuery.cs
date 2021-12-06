using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camunda.Api.Client.History
{
    public class HistoricExternalTaskLogQuery : SortableQuery<HistoricExternalTaskTaskSorting, HistoricExternalTaskLogQuery>
    {
        /// <summary>
        /// Filter by historic external task log id.
        /// </summary>
        public string LogId { get; set; }

        /// <summary>
        /// Filter by external task id.
        /// </summary>
        public string ExternalTaskId { get; set; }

        /// <summary>
        /// Filter by an external task topic.
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Filter by the id of the worker that the task was most recently locked by. 
        /// </summary>
        public string WorkerId { get; set; }

        /// <summary>
        /// Filter by external task exception message.  
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed activity ids. 
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds { get; set; }

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds { get; set; }

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionIds { get; set; }

        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by process definition key.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Only include historic external task log entries that belong to no tenant. Value may only be true, as false is the default behavior. 
        /// </summary>
        public bool WithoutTenantId { get; set; }

        /// <summary>
        /// Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid long value
        /// </summary>
        public long PriorityLowerThanOrEquals { get; set; }

        /// <summary>
        /// Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long PriorityHigherThanOrEquals { get; set; }

        /// <summary>
        /// Only include creation logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool CreationLog { get; set; }

        /// <summary>
        /// Only include failure logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool FailureLog { get; set; }

        /// <summary>
        /// Only include success logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool SuccessLog { get; set; }

        /// <summary>
        /// 	Only include deletion logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DeletionLog { get; set; }
    }

    public enum HistoricExternalTaskTaskSorting
    {
        Timestamp,
        TaskId,
        TopicName,
        WorkerId,
        Retries,
        Priority,
        ActivityId,
        ActivityInstanceId,
        ExecutionId,
        ProcessInstanceId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        TenantId
    }
}