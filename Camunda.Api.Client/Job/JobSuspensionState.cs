﻿namespace Camunda.Api.Client.Job
{
    public class JobSuspensionState : SuspensionState
    {
        /// <summary>
        /// The job definition id of the jobs to activate or suspend.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// The process instance id of the jobs to activate or suspend.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The process definition id of the jobs to activate or suspend.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The process definition key of the jobs to activate or suspend.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Only activate or suspend jobs of a process definition which belongs to a tenant with the given id.
        /// </summary>
        public string ProcessDefinitionTenantId { get; set; }
        /// <summary>
        /// Only activate or suspend jobs of a process definition which belongs to no tenant.
        /// </summary>
        public bool ProcessDefinitionWithoutTenantId { get; set; }
    }
}
