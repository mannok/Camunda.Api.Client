using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionQuery : QueryParameters
    {
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Filter by process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds { get; set; } = new List<string>();
        /// <summary>
        /// Filter by process definition category. Exact match.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Filter by process definition categories that the parameter is a substring of.
        /// </summary>
        public string CategoryLike { get; set; }
        /// <summary>
        /// Filter by process definition name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Filter by process definition names that the parameter is a substring of.
        /// </summary>
        public string NameLike { get; set; }
        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// Filter by process definition key, i.e. the id in the BPMN 2.0 XML. Exact match.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Filter by process definition keys that the parameter is a substring of.
        /// </summary>
        public string KeyLike { get; set; }
        /// <summary>
        /// Filter by the name of the process definition resource. Exact match.
        /// </summary>
        public string ResourceName { get; set; }
        /// <summary>
        /// Filter by names of those process definition resources that the parameter is a substring of.
        /// </summary>
        public string ResourceNameLike { get; set; }
        /// <summary>
        /// Filter by process definition version.
        /// </summary>
        public int? Version { get; set; }
        /// <summary>
        /// Only include those process definitions that are latest versions. Value may only be true, as false is the default behavior.
        /// </summary>
        /// <remarks>
        /// Can only be used in combination with Key or KeyLike. Can also be used without any other criteria which will then give all the latest versions of all the deployed process definitions.
        /// For multi-tenancy: select the latest deployed process definitions for each tenant. If a process definition is deployed for multiple tenants then all process definitions are selected.
        /// </remarks>
        public bool LatestVersion { get; set; } = false;
        /// <summary>
        /// Only include suspended process definitions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended { get; set; } = false;
        /// <summary>
        /// Only selects process definitions with the given incident type.
        /// </summary>
        public string IncidentType { get; set; }
        /// <summary>
        /// Only selects process definitions with the given incident id.
        /// </summary>
        public string IncidentId { get; set; }
        /// <summary>
        /// Only selects process definitions with the given incident message.
        /// </summary>
        public string IncidentMessage { get; set; }
        /// <summary>
        /// Only selects process definitions with an incident message like the given.
        /// </summary>
        public string IncidentMessageLike { get; set; }
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Include process definitions which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        [JsonProperty("includeProcessDefinitionsWithoutTenantId")]
        public bool IncludeDefinitionsWithoutTenantId { get; set; } = false;
        /// <summary>
        /// Filter by the version tag.
        /// </summary>
        public string VersionTag { get; set; }
        /// <summary>
        /// Filter by the version tag that the parameter is a substring of.
        /// </summary>
        public string VersionTagLike { get; set; }
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter. Note: Sorting by <see cref="VersionTag"/> is string based. The version will not be interpreted. As an example, the sorting could return v0.1.0, v0.10.0, v0.2.0.
        /// </summary>
        public ProcessDefinitionSorting SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum ProcessDefinitionSorting
    {
        Id,
        Key,
        Category,
        Name,
        Version,
        DeploymentId,
        TenantId,
        VersionTag
    }
}
