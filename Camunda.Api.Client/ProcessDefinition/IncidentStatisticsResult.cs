
namespace Camunda.Api.Client.ProcessDefinition
{
    public class IncidentStatisticsResult
    {
        /// <summary>
        /// The type of the incident the number of incidents is aggregated for.
        /// </summary>
        public string IncidentType { get; set; }
        /// <summary>
        /// The total number of incidents for the corresponding incident type.
        /// </summary>
        public int IncidentCount { get; set; }

        public override string ToString() => $"{IncidentType} ({IncidentCount})";
    }
}
