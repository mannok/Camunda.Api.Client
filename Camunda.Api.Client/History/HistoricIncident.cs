using System;

namespace Camunda.Api.Client.History
{
    public class HistoricIncident
    {
        /// <summary>
        /// The id of the incident.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The key of the process definition this incident is associated with.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The id of the process definition this incident is associated with.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id of the process instance this incident is associated with.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the execution this incident is associated with.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// The time this incident happened.
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// The time this incident has been deleted or resolved.
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// The type of incident, for example: failedJobs will be returned in case of an incident which identified a failed job during
        /// </summary>
        public string IncidentType { get; set; }
        /// <summary>
        /// The id of the activity this incident is associated with.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// The id of the associated cause incident which has been triggered.
        /// </summary>
        public string CauseIncidentId { get; set; }
        /// <summary>
        /// The id of the associated root cause incident which has been triggered.
        /// </summary>
        public string RootCauseIncidentId { get; set; }
        /// <summary>
        /// The payload of this incident.
        /// </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// The message of this incident.
        /// </summary>
        public string IncidentMessage { get; set; }
        /// <summary>
        /// The id of the tenant this incident is associated with.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// The job definition id the incident is associated with.
        /// </summary>
        public string JobDefinitionId { get; set; }
        /// <summary>
        /// If true, this incident is open.
        /// </summary>
        public bool Open { get; set; }
        /// <summary>
        /// If true, this incident has been deleted.
        /// </summary>
        public bool Deleted { get; set; }
        /// <summary>
        /// If true, this incident has been resolved.
        /// </summary>
        public bool Resolved { get; set; }

        public override string ToString() => Id;
    }
}
