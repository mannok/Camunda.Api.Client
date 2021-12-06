﻿using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class DeleteProcessInstances
    {
        /// <summary>
        /// A list process instance ids to delete.
        /// </summary>
        public List<string> ProcessInstanceIds { get; set; }
        /// <summary>
        /// A process instance query like the request body for <see cref="ProcessInstanceService.Query(ProcessInstanceQuery)"/>.
        /// </summary>
        public ProcessInstanceQuery ProcessInstanceQuery { get; set; }
        /// <summary>
        /// A string with delete reason.
        /// </summary>
        public string DeleteReason { get; set; }
    }
}
