using System;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstance
    {
        /// <summary>
        /// The id of the activity instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the parent activity instance, for example a sub process instance.
        /// </summary>
        public string ParentActivityInstanceId { get; set; }
        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// The name of the activity that this object is an instance of.
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// The type of the activity that this object is an instance of.
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// The key of the process definition that this activity instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The id of the process definition that this activity instance belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id of the process instance that this activity instance belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the execution that executed this activity instance.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The id of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance.
        /// </summary>
        public string CalledProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance.
        /// </summary>
        public string CalledCaseInstanceId { get; set; }
        /// <summary>
        /// The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        public string Assignee { get; set; }
        /// <summary>
        /// The time the instance was started. Has the format yyyy-MM-dd'T'HH:mm:ss.
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// The time the instance ended. Has the format yyyy-MM-dd'T'HH:mm:ss.
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public long DurationInMillis { get; set; }
        /// <summary>
        /// If true, this activity instance is canceled.
        /// </summary>
        public bool Canceled { get; set; }
        /// <summary>
        /// If true, this activity instance did complete a BPMN 2.0 scope.
        /// </summary>
        public bool CompleteScope { get; set; }
        /// <summary>
        /// The tenant id of the activity instance.
        /// </summary>
        public string TenantId { get; set; }

        public override string ToString() => Id;
    }
}
