using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Execution
{
    public class ExecutionQuery : SortableQuery<ExecutionSorting, ExecutionQuery>
    {
        /// <summary>
        /// Filter by the key of the process definition the executions run on.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Filter by the business key of the process instances the executions belong to.
        /// </summary>
        public string BusinessKey { get; set; }
        /// <summary>
        /// Filter by the process definition the executions run on.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Filter by the id of the process instance the execution belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the activity the execution currently executes.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// Select only those executions that expect a signal of the given name.
        /// </summary>
        public string SignalEventSubscriptionName { get; set; }
        /// <summary>
        /// Select only those executions that expect a message of the given name.
        /// </summary>
        public string MessageEventSubscriptionName { get; set; }
        /// <summary>
        /// Only include active executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Only include suspended executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// Filter by the incident id.
        /// </summary>
        public string IncidentId { get; set; }
        /// <summary>
        /// Filter by the incident type.
        /// </summary>
        public string IncidentType { get; set; }
        /// <summary>
        /// Filter by the incident message. Exact match.
        /// </summary>
        public string IncidentMessage { get; set; }
        /// <summary>
        /// Filter by the incident message that the parameter is a substring of.
        /// </summary>
        public string IncidentMessageLike { get; set; }
        /// <summary>
        /// Filter by a list of tenant ids. An execution must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Array to only include executions that have variables with certain values. 
        /// The array consists of objects with the three properties key, operator and value.key(String) is the variable name, operator (String) is the comparison operator to be used and value the variable value.
        /// Value may be String, Number or Boolean.
        /// </summary>
        public List<VariableQueryParameter> Variables { get; set; } = new List<VariableQueryParameter>();

        /// <summary>
        /// Array to only include executions that belong to a process instance with variables with certain values. 
        /// A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        /// </summary>
        /// <remarks>Values are always treated as String objects on server side.</remarks>
        public List<VariableQueryParameter> ProcessVariables { get; set; } = new List<VariableQueryParameter>();
    }

    public enum ExecutionSorting
    {
        InstanceId,
        DefinitionKey,
        DefinitionId,
        TenantId
    }
}
