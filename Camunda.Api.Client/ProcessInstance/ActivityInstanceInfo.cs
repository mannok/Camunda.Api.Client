using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ActivityInstanceInfo
    {
        /// <summary>
        /// The id of the activity instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public string ParentActivityInstanceId { get; set; }
        /// <summary>
        /// The id of the activity.
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// The type of activity (corresponds to the XML element name in the BPMN 2.0, e.g. 'userTask').
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// The id of the process instance this activity instance is part of.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// A list of child activity instances.
        /// </summary>
        public List<ActivityInstanceInfo> ChildActivityInstances { get; set; }
        /// <summary>
        /// A list of child transition instances. A transition instance represents an execution waiting in an asynchronous continuation.
        /// </summary>
        public List<TransitionInstanceInfo> ChildTransitionInstances { get; set; }
        /// <summary>
        /// A list of execution ids.
        /// </summary>
        public List<string> ExecutionIds { get; set; }

        public override string ToString() => Id;
    }
}
