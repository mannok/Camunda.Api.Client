namespace Camunda.Api.Client.Execution
{
    public class ExecutionInfo
    {
        /// <summary>
        /// The id of the execution.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the process instance that this execution instance belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// A flag indicating whether the execution has ended or not.
        /// </summary>
        public bool Ended { get; set; }
        /// <summary>
        /// The tenant id of the execution.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Id;
    }
}
