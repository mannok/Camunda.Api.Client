using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class CleanableProcessInstanceReportResult
    {
        /// <summary>
        ///  The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        ///  The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string ProcessDefinitionName { get; set; }

        /// <summary>
        ///  The version of the process definition.
        /// </summary>
        public int ProcessDefinitionVersion { get; set; }

        /// <summary>
        ///  The history time to live of the process definition.
        /// </summary>
        public int HistoryTimeToLive { get; set; }

        /// <summary>
        ///  The count of the finished historic process instances.
        /// </summary>
        public int FinishedProcessInstanceCount { get; set; }

        /// <summary>
        ///  The count of the cleanable historic process instances, referring to history time to live.
        /// </summary>
        public int CleanableProcessInstanceCount { get; set; }

        /// <summary>
        ///  The tenant id of the process definition.
        /// </summary>
        public string TenantId { get; set; }
    }
}
