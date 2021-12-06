namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionInfo
    {
        /// <summary>
        /// The id of the case execution.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is active or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// The description of the activity this case execution belongs to.
        /// </summary>
        public string ActivityDescription { get; set; }

        /// <summary>
        /// The id of the activity this case execution belongs to.
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// The name of the activity this case execution belongs to.
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// The type of the activity this case execution belongs to.
        /// </summary>
        public string ActivityType { get; set; }

        /// <summary>
        /// The id of the case definition this case execution belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The id of the case instance this case execution belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is disabled or not.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is enabled or not.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// The id of the parent of this case execution belongs to.
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is repeatable or not.
        /// </summary>
        public bool Repeatable { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is a repetition or not.
        /// </summary>
        public bool Repetition { get; set; }

        /// <summary>
        /// A flag indicating whether the case execution is required or not.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// The tenant id of the case execution.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Id;
    }
}
