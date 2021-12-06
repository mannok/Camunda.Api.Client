namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionInfo
    {
        /// <summary>
        /// The id of the case definition.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The category of the case definition.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The deployment id of the case definition.
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// History time to live value of the case definition. Is used within LINK.
        /// </summary>
        public int HistoryTimeToLive { get; set; }

        /// <summary>
        /// The key of the case definition, i.e., the id of the CMMN XML case definition.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The name of the case definition.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The file name of the case definition.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The tenant id of the case definition.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// The version of the case definition that the engine assigned to it.
        /// </summary>
        public int Version { get; set; }

        public override string ToString() => Id;
    }
}
