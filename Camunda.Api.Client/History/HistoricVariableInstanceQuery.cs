using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricVariableInstanceQuery : SortableQuery<HistoricVariableInstanceQuerySorting, HistoricVariableInstanceQuery>
    {
        /// <summary>
        /// Filter by the process instance the variable belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the case instance the variable belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Filter by variable name.
        /// </summary>
        public string VariableName { get; set; }
        /// <summary>
        /// Restrict to variables with a name like the parameter.
        /// </summary>
        public string VariableNameLike { get; set; }
        /// <summary>
        /// Filter by variable value. May be <c>String</c>, <c>Number</c> or <c>Boolean</c>.
        /// </summary>
        public object VariableValue { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed task ids.
        /// </summary>
        [JsonProperty("taskIdIn")]
        public List<string> TaskIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed case execution ids.
        /// </summary>
        [JsonProperty("CaseExecutionIdIn")]
        public List<string> CaseExecutionIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed case activity ids.
        /// </summary>
        [JsonProperty("caseActivityIdIn")]
        public List<string> CaseActivityIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed process instance ids.
        /// </summary>
        [JsonProperty("processInstanceIdIn")]
        public List<string> ProcessInstanceIds { get; set; }
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }
    }

    public enum HistoricVariableInstanceQuerySorting
    {
        InstanceId,
        VariableName,
        TenantId
    }
}
