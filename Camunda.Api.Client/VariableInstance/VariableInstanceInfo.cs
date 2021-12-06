namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceInfo : NamedVariableValue
    {
        /// <summary>
        /// The id of the variable instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the process instance that this variable instance belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the execution that this variable instance belongs to.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The id of the case instance that this variable instance belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// The id of the case execution that this variable instance belongs to.
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// The id of the task that this variable instance belongs to.
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// The id of the activity instance that this variable instance belongs to.
        /// </summary>
        public string ActivityInstanceId { get; set; }
        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// The id of the tenant that this variable instance belongs to.
        /// </summary>
        public string TenantId { get; set; }
    }
}
