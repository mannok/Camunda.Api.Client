using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricJobLogQuery : SortableQuery<HistoricJobLogQuerySorting, HistoricJobLogQuery>
    {
        /// <summary>
        /// Filter by historic job log id.
        /// </summary>
        public string LogId { get; set; }
        /// <summary>
        /// Filter by job id.
        /// </summary>
        public string JobId { get; set; }
        /// <summary>
        /// Filter by job exception message.
        /// </summary>
        public string JobExceptionMessage { get; set; }
        /// <summary>
        /// Filter by job definition id.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// Filter by job definition type.
        /// </summary>
        public string JobDefinitionType { get; set; }
        /// <summary>
        /// Filter by job definition configuration.
        /// </summary>
        public string JobDefinitionConfiguration { get; set; }
        /// <summary>
        /// Only include historic job logs which belong to one of the passed activity ids.
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds { get; set; }
        /// <summary>
        /// Only include historic job logs which belong to one of the passed execution ids.
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
        /// Filter by deployment id.
        /// </summary>
        public string DeploymentId { get; set; }
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
        /// Only include deletion logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DeletionLog { get; set; }
        /// <summary>
        /// Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long JobPriorityHigherThanOrEquals { get; set; }
        /// <summary>
        /// Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long JobPriorityLowerThanOrEquals { get; set; }
        /// <summary>
        /// Only include historic job log entries which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }
    }

    public enum HistoricJobLogQuerySorting
    {
        JobId,
        JobDefinitionId,
        JobDueDate,
        JobRetries,
        JobPriority,
        ActivityId,
        Timestamp,
        ExecutionId,
        ProcessInstanceId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        DeploymentId,
        Occurrence,
        TenantId
    }
}
