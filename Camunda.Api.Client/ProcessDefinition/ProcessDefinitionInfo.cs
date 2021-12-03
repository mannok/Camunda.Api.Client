
namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionInfo
    {
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The key of the process definition, i.e. the id of the BPMN 2.0 XML process definition.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The category of the process definition.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// The description of the process definition.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The version of the process definition that the engine assigned to it.
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// The file name of the process definition.
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// The deployment id of the process definition.
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// The file name of the process definition diagram, if it exists.
        /// </summary>
        public string Diagram { get; set; }
        /// <summary>
        /// A flag indicating whether the definition is suspended or not.
        /// </summary>
        public bool Suspended { get; set; }
        /// <summary>
        /// The tenant id of the process definition.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// The version tag of the process definition.
        /// </summary>
        public string VersionTag { get; set; }

        public override string ToString() => Id;
    }
}
