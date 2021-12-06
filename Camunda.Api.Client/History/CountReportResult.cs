namespace Camunda.Api.Client.History
{
    public class CountReportResult
    {
        /// <summary>
        /// The task name of the task. It is only available when the groupBy-parameter is set to taskName. Else the value is null.
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// The id of the process definition
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string processDefinitionName { get; set; }

        /// <summary>
        /// The number of tasks which have the given definition.
        /// </summary>
        public long Count { get; set; }
    }
}
