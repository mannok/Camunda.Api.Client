namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceOutputValue : VariableValue
    {
        /// <summary>
        /// The id of the decision output value.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The id of the decision instance the output value belongs to.
        /// </summary>
        public string DecisionInstanceId { get; set; }

        /// <summary>
        /// The id of the clause the output value belongs to.
        /// </summary>
        public string ClauseId { get; set; }

        /// <summary>
        /// The name of the clause the output value belongs to.
        /// </summary>
        public string ClauseName { get; set; }

        /// <summary>
        /// The id of the rule the output value belongs to.
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// The order of the rule the output value belongs to.
        /// </summary>
        public int RuleOrder { get; set; }

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The name of the output variable.
        /// </summary>
        public string VariableName { get; set; }
    }
}