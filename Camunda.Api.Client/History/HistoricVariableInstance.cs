using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricVariableInstance : VariableValue
    {
        /// <summary>
        /// The id of the variable instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the variable instance.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The key of the process definition the variable instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The id of the process definition the variable instance belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id the process instance belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The execution id the variable instance belongs to.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The id of the activity instance in which the variable is valid.
        /// </summary>
        public string ActivityInstanceId { get; set; }
        /// <summary>
        /// The key of the case definition the variable instance belongs to.
        /// </summary>
        public string CaseDefinitionKey { get; set; }
        /// <summary>
        /// The id of the case definition the variable instance belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }
        /// <summary>
        /// The case instance id the variable instance belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// The case execution id the variable instance belongs to.
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// The id of the task the variable instance belongs to.
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// The id of the tenant that this variable instance belongs to.
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// The current state of the variable. 
        /// </summary>
        public HistoricVariableInstanceState State { get; set; }

        public override string ToString() => $"{Name} = {base.ToString()}";
    }

    public enum HistoricVariableInstanceState
    {
        /// <summary>
        /// Created
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// Deleted
        /// </summary>
        [EnumMember(Value = "DELETED")]
        Deleted,
    }
}
