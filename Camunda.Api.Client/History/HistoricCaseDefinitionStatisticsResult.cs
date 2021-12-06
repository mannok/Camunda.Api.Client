namespace Camunda.Api.Client.History
{
    public class HistoricCaseDefinitionStatisticsResult
    {
        public string Id { get; set; }

        public int Active { get; set; }

        public int Available { get; set; }

        public int Completed { get; set; }

        public int Disabled { get; set; }

        public int Enabled { get; set; }

        public int Terminated { get; set; }

        public override string ToString() => Id;
    }
}