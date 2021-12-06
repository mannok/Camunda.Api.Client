using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstanceQuery : SortableQuery<HistoricActivityInstanceQuerySorting, HistoricActivityInstanceQuery>
    {
        /// <summary>
        /// Filter by activity instance id.
        /// </summary>
        public string ActivityInstanceId { get; set; }
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Filter by the id of the execution that executed the activity instance.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Filter by the activity id (according to BPMN 2.0 XML).
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// Filter by the activity name (according to BPMN 2.0 XML).
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// Filter by activity type.
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// Only include activity instances that are user tasks and assigned to a given user.
        /// </summary>
        public string TaskAssignee { get; set; }
        /// <summary>
        /// Only include finished activity instances.
        /// </summary>
        public bool Finished { get; set; }
        /// <summary>
        /// Only include unfinished activity instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Unfinished { get; set; }
        /// <summary>
        /// Only include activity instances which completed a scope. 
        /// </summary>
        public bool CompleteScope { get; set; }
        /// <summary>
        /// Only include canceled activity instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Canceled { get; set; }
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
        /// Filter by a list of tenant ids. An activity instance must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }
    }

    public enum HistoricActivityInstanceQuerySorting
    {
        ActivityInstanceId,
        InstanceId,
        ExecutionId,
        ActivityId,
        ActivityName,
        ActivityType,
        StartTime,
        EndTime,
        Duration,
        DefinitionId,
        TenantId
    }
}
