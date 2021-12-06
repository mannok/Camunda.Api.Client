using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstanceReport : AbstractReport
    {
        /// <summary>
        /// Filter by process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds { get; set; }
        /// <summary>
        /// Filter by process definition keys.
        /// </summary>
        [JsonProperty("processDefinitionKeyIn")]
        public List<string> ProcessDefinitionKeys { get; set; }
        /// <summary>
        /// Restrict to instances that were started after the given date.
        /// </summary>
        public DateTime? StartedAfter { get; set; }
        /// <summary>
        /// Restrict to instances that were started before the given date.
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        public HistoricProcessInstanceReport()
        {
            ReportType = ReportType.Duration;
        }
    }
}
