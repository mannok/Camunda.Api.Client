using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionQuery : QueryParameters
    {
        /// <summary>
        /// Filter by decision definition id.
        /// </summary>
        public string DecisionDefinitionId { get; set; }

        /// <summary>
        /// Filter by decision definition ids.
        /// </summary>
        [JsonProperty("decisionDefinitionIdIn")]
        public List<string> DecisionDefinitionIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter by decision definition name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Filter by decision definition names that the parameter is a substring of.
        /// </summary>
        public string NameLike { get; set; }

        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Filter by decision definition key, i.e.the id in the DMN 1.0 XML.Exact match.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Filter by decision definition keys that the parameter is a substring of.
        /// </summary>
        public string KeyLike { get; set; }

        /// <summary>
        /// Filter by decision definition category. Exact match.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Filter by decision definition categories that the parameter is a substring of.
        /// </summary>
        public string CategoryLike { get; set; }

        /// <summary>
        /// Filter by decision definition version.
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Only include those decision definitions that are latest versions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool LatestVersion = false;

        /// <summary>
        /// Filter by the name of the decision definition resource. Exact match.
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Filter by names of those decision definition resources that the parameter is a substring of.
        /// </summary>
        public string ResourceNameLike { get; set; }

        /// <summary>
        /// Filter by a comma-separated list of tenant ids.A decision definition must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();

        /// <summary>
        /// Only include decision definitions which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId = false;

        /// <summary>
        /// Include decision definitions which belongs to no tenant.Can be used in combination with tenantIdIn.Value may only be true, as false is the default behavior.
        /// </summary>
        [JsonProperty("includeDecisionDefinitionsWithoutTenantId")]
        public bool IncludeDefinitionsWithoutTenantId = false;

        /// <summary>
        /// Sort the results lexicographically by a given criterion.Valid values are category, key, id, name, version, deploymentId and tenantId.Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public DecisionDefinitionSorting SortBy { get; set; }

        /// <summary>
        /// Sort the results in a given order.Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum DecisionDefinitionSorting
    {
        Category,
        Key,
        Id,
        Name,
        Version,
        DeploymentId,
        TenantId
    }
}