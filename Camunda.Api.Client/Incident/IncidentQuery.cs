using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Incident
{
    public class IncidentQuery : QueryParameters
    {
        /// <summary>
        /// Restricts to incidents that have the given id.
        /// </summary>
        public string IncidentId { get; set; }
        /// <summary>
        /// Restricts to incidents that belong to the given incident type.
        /// </summary>
        public string IncidentType { get; set; }
        /// <summary>
        /// Restricts to incidents that have the given incident message.
        /// </summary>
        public string IncidentMessage { get; set; }
        /// <summary>
        /// Restricts to incidents that belong to a process definition with the given id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Restricts to incidents that belong to a process instance with the given id.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Restricts to incidents that belong to an execution with the given id.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Restricts to incidents that belong to an activity with the given id.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// Restricts to incidents that have the given incident id as cause incident.
        /// </summary>
        public string CauseIncidentId { get; set; }
        /// <summary>
        /// Restricts to incidents that have the given incident id as root cause incident.
        /// </summary>
        public string RootCauseIncidentId { get; set; }
        /// <summary>
        /// Restricts to incidents that have the given parameter set as configuration.
        /// </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// Restricts to incidents that have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Restricts to incidents that have one of the given job definition ids.
        /// </summary>
        [JsonProperty("jobDefinitionIdIn")]
        public List<string> JobDefinitionIds { get; set; } = new List<string>();
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/>.
        /// </summary>
        public IncidentSorting SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum IncidentSorting
    {
        IncidentId,
        IncidentTimestamp,
        IncidentType,
        ExecutionId,
        ActivityId,
        ProcessInstanceId,
        ProcessDefinitionId,
        CauseIncidentId,
        RootCauseIncidentId,
        Configuration,
        TenantId
    }

}