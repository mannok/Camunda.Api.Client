using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentQuery : QueryParameters
    {
        /// <summary>
        /// Filter by deployment id.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Filter by the deployment name. Exact match.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard % to express like-strategy such as: starts with (%name), ends with (name%) or contains (%name%).
        /// </summary>
        public string NameLike { get; set; }
        /// <summary>
        /// Filter by the deployment source.
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Filter by the deployment source whereby source is equal to null.
        /// </summary>
        public bool WithoutSource { get; set; }
        /// <summary>
        /// Restricts to all deployments before the given date.
        /// </summary>
        public DateTime? Before { get; set; }
        /// <summary>
        /// Restricts to all deployments after the given date.
        /// </summary>
        public DateTime? After { get; set; }
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Only include deployments which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId { get; set; }
        /// <summary>
        /// Include deployments which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool IncludeDeploymentsWithoutTenantId { get; set; }
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public DeploymentSorting SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum DeploymentSorting
    {
        Id,
        Name,
        DeploymentTime,
        TenantId
    }
}
