namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionDiagram
    {
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// XML string containing the XML that this definition was deployed with.
        /// </summary>
        public string Bpmn20Xml { get; set; }

        public override string ToString() => Id;
    }
}
