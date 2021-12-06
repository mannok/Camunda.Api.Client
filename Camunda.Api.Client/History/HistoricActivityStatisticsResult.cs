namespace Camunda.Api.Client.History
{
    public class HistoricActivityStatisticsResult
    {
        /// <summary>
        /// The id of the activity the results are aggregated for.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The total number of all running instances of the activity.
        /// </summary>
        public int Instances { get; set; }

        /// <summary>
        /// The total number of all canceled instances of the activity. Note: Will be 0 (not null), if canceled activity instances were excluded.
        /// </summary>
        public int Canceled { get; set; }

        /// <summary>
        /// The total number of all finished instances of the activity. Note: Will be 0 (not null), if finished activity instances were excluded. 
        /// </summary>
        public int Finished { get; set; }

        /// <summary>
        /// The total number of all instances which completed a scope of the activity. Note: Will be 0 (not null), if activity instances which completed a scope were excluded.
        /// </summary>
        public int CompleteScope { get; set; }

        /// <summary>
        /// The total number of open incident for the activity. Note: Will be 0 (not null), if incidents is set to false.
        /// </summary>
        public int OpenIncidents { get; set; }

        /// <summary>
        /// The total number of resolved incident for the activity. Note: Will be 0 (not null), if incidents is set to false.
        /// </summary>
        public int ResolvedIncidents { get; set; }

        /// <summary>
        /// The total number of deleted incident for the activity. Note: Will be 0 (not null), if incidents is set to false.
        /// </summary>
        public int DeletedIncidents { get; set; }

        public override string ToString() => Id.ToString();
    }
}
