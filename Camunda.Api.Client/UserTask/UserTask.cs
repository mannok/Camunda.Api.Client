using System;

namespace Camunda.Api.Client.UserTask
{
    public class UserTask
    {
        /// <summary>
        /// The task name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The user assigned to this task.
        /// </summary>
        public string Assignee { get; set; }
        /// <summary>
        /// The due date for the task.
        /// </summary>
        public DateTime? Due { get; set; }
        /// <summary>
        /// The follow-up date for the task.
        /// </summary>
        public DateTime? FollowUp { get; set; }
        /// <summary>
        /// The delegation state of the task. Possible values are RESOLVED and PENDING.
        /// </summary>
        public DelegationState DelegationState { get; set; }
        /// <summary>
        /// The task description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The owner of the task.
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// The id of the parent task, if this task is a subtask.
        /// </summary>
        public string ParentTaskId { get; set; }
        /// <summary>
        /// The priority of the task.
        /// </summary>
        public int Priority { get; set; }
        /// <summary>
        /// The id of the case instance the task belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// If not null, the tenantId for the task.
        /// </summary>
        /// <remarks>The tenant id cannot be changed; only the existing tenant id can be passed.</remarks>
        public string TenantId { get; set; }

        public override string ToString() => Name;
    }
}
