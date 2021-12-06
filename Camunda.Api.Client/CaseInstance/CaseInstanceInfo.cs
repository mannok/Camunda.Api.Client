namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceInfo
    {
        /// <summary>
        /// The id of the case instance.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the case instance is active or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// The business key of the case instance.
        /// </summary>
        public string BusinessKey { get; set; }

        /// <summary>
        /// The id of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// A flag indicating whether the case instance is completed or not.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The tenant id of the case instance.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Id;
    }
}
