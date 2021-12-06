namespace Camunda.Api.Client
{
    public class VariableOrder
    {
        public string VariableName { get; set; }
        public VariableType Type { get; set; }

        public VariableOrder(string variableName, VariableType variableType)
        {
            VariableName = variableName;
            Type = variableType;
        }
    }
}
