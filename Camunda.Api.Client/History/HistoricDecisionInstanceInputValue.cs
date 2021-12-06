namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceInputValue : VariableValue
    {
        /// <summary>
        /// The id of the decision input value.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The id of the decision instance the input value belongs to.
        /// </summary>
        public string DecisionInstanceId { get; set; }

        /// <summary>
        /// The id of the clause the input value belongs to.
        /// </summary>
        public string ClauseId { get; set; }

        /// <summary>
        /// The name of the clause the input value belongs to.
        /// </summary>
        public string ClauseName { get; set; }

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}