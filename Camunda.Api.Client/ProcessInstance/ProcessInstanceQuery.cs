﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceQuery : SortableQuery<ProcessInstanceSorting, ProcessInstanceQuery>
    {
        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// Filter by the key of the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Filter by process instance business key.
        /// </summary>
        public string BusinessKey { get; set; }
        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Filter by the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id.
        /// </summary>
        public string SuperProcessInstance { get; set; }
        /// <summary>
        /// Restrict query to all process instances that have the given process instance as a sub process instance. Takes a process instance id.
        /// </summary>
        public string SubProcessInstance { get; set; }
        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string SuperCaseInstance { get; set; }
        /// <summary>
        /// Restrict query to all process instances that have the given case instance as a sub case instance. Takes a case instance id.
        /// </summary>
        public string SubCaseInstance { get; set; }
        /// <summary>
        /// Only include active process instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Only include suspended process instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// Filter by a list of process instance ids. Must be an array of Strings.
        /// </summary>
        public List<string> ProcessInstanceIds { get; set; }
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
        /// Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Must be a JSON array of Strings.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Only include process instances which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId { get; set; }
        /// <summary>
        /// Filter by a list of activity ids. A process instance must currently wait in a leaf activity with one of the given activity ids.
        /// </summary>
        [JsonProperty("activityIdIn")] 
        public List<string> ActivityIds { get; set; } = new List<string>();
        /// <summary>
        /// An array to only include process instances that have variables with certain values. 
        /// The array consists of objects with the three properties name, operator and value.
        /// Name(String) is the variable name, operator is the comparison operator to be used and value the variable value. 
        /// Value may be String, Number or Boolean.
        /// </summary>
        public List<VariableQueryParameter> Variables { get; set; } = new List<VariableQueryParameter>();
    }

    public enum ProcessInstanceSorting
    {
        InstanceId,
        DefinitionKey,
        DefinitionId,
        TenantId,
    }
}
