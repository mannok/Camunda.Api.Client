namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionInfo
    {
        /// <summary>
        /// The id of the decision definition.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The category of the decision definition.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The id of the decision requirements definition this decision definition belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionId { get; set; }

        /// <summary>
        /// The key of the decision requirements definition this decision definition belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionKey { get; set; }

        /// <summary>
        /// The deployment id of the decision definition.
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// History time to live value of the decision definition. Is used within LINK.
        /// </summary>
        public int HistoryTimeToLive { get; set; }

        /// <summary>
        /// The key of the decision definition, i.e., the id of the DMN 1.0 XML decision definition.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The name of the decision definition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The file name of the decision definition.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The tenant id of the decision definition.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// The version of the decision definition that the engine assigned to it.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// The version tag of the decision or null when no version tag is set
        /// </summary>
        public string VersionTag { get; set; }

        /// <summary>
        /// Filter by the version tag that the parameter is a substring of.
        /// </summary>
        public string VersionTagLike { get; set; }

        public override string ToString() => Id;
    }
}
