﻿using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class DeleteHistoricProcessInstances
    {
        /// <summary>
        /// A list historic process instance ids to delete.
        /// </summary>
        public List<string> HistoricProcessInstanceIds { get; set; }
        /// <summary>
        /// A historic process instance query.
        /// </summary>
        public HistoricProcessInstanceQuery HistoricProcessInstanceQuery { get; set; }
        /// <summary>
        /// A string with delete reason.
        /// </summary>
        public string DeleteReason { get; set; }
    }
}
