using System;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstance
    {
        /// <summary>
        /// The id of the process instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        public string BusinessKey { get; set; }
        /// <summary>
        /// The id of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The key of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The name of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionName { get; set; }
        /// <summary>
        /// The time the instance was started.
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The time the instance ended.
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public long DurationInMillis { get; set; }
        /// <summary>
        /// The id of the user who started the process instance.
        /// </summary>
        public string StartUserId { get; set; }
        /// <summary>
        /// The id of the initial activity that was executed (e.g., a start event).
        /// </summary>
        public string StartActivityId { get; set; }
        /// <summary>
        /// The provided delete reason in case the process instance was canceled during execution./// </summary>
        public string DeleteReason { get; set; }
        /// <summary>
        /// The id of the parent process instance, if it exists.
        /// </summary>
        public string SuperProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string SuperCaseInstanceId { get; set; }
        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// The tenant id of the process instance.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Last state of the process instance.
        /// </summary>
        public ProcessInstanceState State { get; set; }

        public override string ToString() => Id;
    }

    public enum ProcessInstanceState
    {
        /// <summary>
        /// Running process instance
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        Suspended,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "EXTERNALLY_TERMINATED")]
        ExternallyTerminated,
        /// <summary>
        /// Terminated internally, for instance by terminating boundary event
        /// </summary>
        [EnumMember(Value = "INTERNALLY_TERMINATED")]
        InternallyTerminated,
    }
}
