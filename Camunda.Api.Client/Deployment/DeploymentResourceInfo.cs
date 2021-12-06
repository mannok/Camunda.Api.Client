
namespace Camunda.Api.Client.Deployment
{
    public class DeploymentResourceInfo
    {
        /// <summary>
        /// The id of the deployment resource.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the deployment resource.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The id of the deployment.
        /// </summary>
        public string DeploymentId { get; set; }

        public override string ToString() => Name ?? Id;
    }
}
