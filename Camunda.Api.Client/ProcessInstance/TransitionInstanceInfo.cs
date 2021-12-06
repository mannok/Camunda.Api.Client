namespace Camunda.Api.Client.ProcessInstance
{
    public class TransitionInstanceInfo
    {
        /// <summary>
        /// The id of the transition instance.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public string ParentActivityInstanceId { get; set; }
        /// <summary>
        /// The id of the process instance.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job)
        /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
        /// The name of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job)
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// The type of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job). Corresponds to the XML element name in the BPMN 2.0, e.g. 'userTask'.
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// A list of execution ids.
        /// </summary>
        public string ExecutionId { get; set; }

        public override string ToString() => Id;
    }
}
