namespace Camunda.Api.Client.ProcessDefinition
{
    public class FormInfo
    {
        /// <summary>
        /// The form key for the process definition.
        /// </summary>
        public string Key { get; set; }
        public string ContextPath { get; set; }

        public override string ToString() => Key;
    }
}
