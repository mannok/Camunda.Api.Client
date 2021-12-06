namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionDiagram
    {
        /// <summary>
        /// The id of the decision definition.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// An escaped XML string containing the XML that this decision definition was deployed with. Carriage returns, line feeds and quotation marks are escaped.
        /// </summary>
        public string DmnXml { get; set; }

        public override string ToString() => Id;
    }
}