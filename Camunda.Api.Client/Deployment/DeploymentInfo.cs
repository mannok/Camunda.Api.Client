using System;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentInfo
    {
        /// <summary>
        /// The id of the deployment.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The source of the deployment.
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// The time when the deployment was created.
        /// </summary>
        public DateTime DeploymentTime { get; set; }
        /// <summary>
        /// The tenant id of the deployment.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Name ?? Id;

    }
}
