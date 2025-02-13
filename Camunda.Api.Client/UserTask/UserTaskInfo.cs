﻿using System;

namespace Camunda.Api.Client.UserTask
{
    public class UserTaskInfo : UserTask
    {
        /// <summary>
        /// The id of the task.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The time the task was created.
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// The id of the execution the task belongs to.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The id of the process definition this task belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id of the process instance this task belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The task definition key.
        /// </summary>
        public string TaskDefinitionKey { get; set; }
        /// <summary>
        /// The id of the case execution the task belongs to.
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// The id of the case definition the task belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }
        /// <summary>
        /// If not null, the form key for the task.
        /// </summary>
        public string FormKey { get; set; }

        public override string ToString() => base.ToString() ?? Id;
    }
}
