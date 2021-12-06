#region Usings

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceQuery
    {
        [JsonProperty("caseInstanceId")]
        public string CaseInstanceId { get; set; }

        [JsonProperty("businessKey")]
        public string BusinessKey { get; set; }

        [JsonProperty("caseDefinitionId")]
        public string CaseDefinitionId { get; set; }

        [JsonProperty("caseDefinitionKey")]
        public string CaseDefinitionKey { get; set; }

        [JsonProperty("deploymentId")]
        public string DeploymentId { get; set; }

        [JsonProperty("superProcessInstance")]
        public string SuperProcessInstance { get; set; }

        [JsonProperty("subProcessInstance")]
        public string SubProcessInstance { get; set; }

        [JsonProperty("superCaseInstance")]
        public string SuperCaseInstance { get; set; }

        [JsonProperty("subCaseInstance")]
        public string SubCaseInstance { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }

        [JsonProperty("tenantIdIn")]
        public List<string> TenantIdIn { get; set; }

        [JsonProperty("withoutTenantId")]
        public bool? WithoutTenantId { get; set; }

        [JsonProperty("variables")]
        public List<CaseInstanceQueryVariable> Variables { get; set; }

        [JsonProperty("variableNamesIgnoreCase")]
        public bool VariableNamesIgnoreCase { get; set; }

        [JsonProperty("variableValuesIgnoreCase")]
        public bool VariableValuesIgnoreCase { get; set; }

        [JsonProperty("sorting")]
        public List<CaseInstanceSorting> Sorting { get; set; }
    }
}
