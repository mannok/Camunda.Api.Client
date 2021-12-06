using System.Collections.Generic;

namespace Camunda.Api.Client.Deployment
{
    public class RedeploymentInfo
    {
        /// <summary>
        /// Sets the source of the deployment.
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// A list of deployment resource ids to re-deploy.
        /// </summary>
        public List<string> ResourceIds { get; set; } = new List<string>();
        /// <summary>
        /// A list of deployment resource names to re-deploy.
        /// </summary>
        public List<string> ResourceNames { get; set; } = new List<string>();
    }
}
