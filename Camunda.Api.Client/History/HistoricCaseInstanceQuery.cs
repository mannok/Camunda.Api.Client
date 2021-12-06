using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstanceQuery : SortableQuery<HistoricCaseInstanceQuerySorting, HistoricCaseInstanceQuery>
    {
        /// <summary>
        /// Filter by the case definition the instances run on.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        [JsonProperty("caseActivityIdIn")]
        public List<string> CaseActivityIds { get; set; }

        /// <summary>
        /// Restrict query to one case instance that has a sub process instance with the given id.
        /// </summary>
        public string SubProcessInstanceId { get; set; }

        /// <summary>
        /// Only include active case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Only include completed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Only include terminated case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Terminated { get; set; }

        /// <summary>
        /// Only include closed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Closed { get; set; }

        /// <summary>
        /// Only include not closed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool NotClosed { get; set; }
    }

    public enum HistoricCaseInstanceQuerySorting
    {
        InstanceId,
        DefinitionId,
        BusinessKey,
        CreateTime,
        CloseTime,
        Duration,
        TenantId
    }
}