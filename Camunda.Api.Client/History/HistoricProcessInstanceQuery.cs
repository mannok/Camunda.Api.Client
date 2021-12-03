using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstanceQuery : SortableQuery<HistoricProcessInstanceQuerySorting, HistoricProcessInstanceQuery>
    {
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by process instance ids.
        /// </summary>
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Filter by the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by the name of the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionName { get; set; }

        /// <summary>
        /// Filter by process definition names that the parameter is a substring of.
        /// </summary>
        public string ProcessDefinitionNameLike { get; set; }

        /// <summary>
        /// Filter by process instance business key.
        /// </summary>
        [JsonProperty("processInstanceBusinessKey")]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Filter by process instance business key that the parameter is a substring of.
        /// </summary>
        [JsonProperty("processInstanceBusinessKeyLike")]
        public string BusinessKeyLike { get; set; }

        /// <summary>
        /// Only include finished process instances.
        /// </summary>
        public bool Finished { get; set; } = false;

        /// <summary>
        /// Only include unfinished process instances.
        /// </summary>
        public bool Unfinished { get; set; } = false;

        /// <summary>
        /// Only include process instances which have an incident.
        /// </summary>
        public bool WithIncidents { get; set; } = false;

        /// <summary>
        /// Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents.
        /// </summary>
        public string IncidentStatus { get; set; }

        /// <summary>
        /// Filter by the incident message. Exact match.
        /// </summary>
        public string IncidentMessage { get; set; }

        /// <summary>
        /// Filter by the incident message that the parameter is a substring of.
        /// </summary>
        public string IncidentMessageLike { get; set; }

        /// <summary>
        /// Only include process instances that were started by the given user.
        /// </summary>
        public string StartedBy { get; set; }

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id.
        /// </summary>
        public string SuperProcessInstanceId { get; set; }

        /// <summary>
        /// Restrict query to one process instance that has a sub process instance with the given id.
        /// </summary>
        public string SubProcessInstanceId { get; set; }

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string SuperCaseInstanceId { get; set; }

        /// <summary>
        /// Restrict query to one process instance that has a sub case instance with the given id.
        /// </summary>
        public string SubCaseInstanceId { get; set; }

        /// <summary>
        /// Restrict to instances that were started before the given date.
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Restrict to instances that were started after the given date.
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Restrict to instances that were finished before the given date.
        /// </summary>
        public DateTime? FinishedBefore { get; set; }

        /// <summary>
        /// Restrict to instances that were finished after the given date.
        /// </summary>
        public DateTime? FinishedAfter { get; set; }

        /// <summary>
        /// Filter by the key of the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Exclude instances that belong to a set of process definitions. An array of process definition keys.
        /// </summary>
        public List<string> ProcessDefinitionKeyNotIn { get; set; }

        /// <summary>
        /// Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Must be an array of Strings.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// Restrict to instances that have an active activity with one of given ids.
        /// </summary>
        [JsonProperty("activeActivityIdIn")]
        public List<string> ActiveActivityIds { get; set; }

        /// <summary>
        /// Array to only include process instances that have/had variables with certain values.
        /// </summary>
        public List<VariableQueryParameter> Variables { get; set; } = new List<VariableQueryParameter>();
    }

    public enum HistoricProcessInstanceQuerySorting
    {
        InstanceId,
        DefinitionId,
        BusinessKey,
        StartTime,
        EndTime,
        Duration,
        TenantId
    }
}