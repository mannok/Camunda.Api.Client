#region Usings

using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceQueryVariable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operator")]
        public ConditionOperator Operator { get; set; }

        [JsonProperty("value")] 
        public object Value { get; set; }
    }
}
