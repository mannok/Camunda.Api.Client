using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDetailQuery : QueryParameters
    {
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the execution that executed the activity instance.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Filter by activity instance id.
        /// </summary>
        public string ActivityInstanceId { get; set; }
        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case execution with the given id.
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// Variable instance id
        /// </summary>
        public string VariableInstanceId { get; set; }
        /// <summary>
        /// Only select variable instances with one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }
        /// <summary>
        /// User operation id
        /// </summary>
        public string UserOperationId { get; set; }
        /// <summary>
        /// Form fields
        /// </summary>
        public bool? FormFields { get; set; }
        /// <summary>
        /// Variable updates
        /// </summary>
        public bool? VariableUpdates { get; set; }
        /// <summary>
        /// Exclude task details
        /// </summary>
        public bool? ExcludeTaskDetails { get; set; }

        
    }

}
