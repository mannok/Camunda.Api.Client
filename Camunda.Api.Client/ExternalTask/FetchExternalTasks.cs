
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class FetchExternalTasks
    {
        /// <summary>
        /// Mandatory. The maximum number of tasks to return.
        /// </summary>
        public int MaxTasks { get; set; }
        /// <summary>
        /// Mandatory. The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id.
        /// </summary>
        public string WorkerId { get; set; }

        /// <summary>
        /// Indicates whether the task should be fetched based on its priority or arbitrarily.
        /// </summary>
        public bool UsePriority { get; set; }

        /// <summary>
        /// The Long Polling timeout in milliseconds. The value cannot be set larger than 1.800.000 milliseconds (corresponds to 30 minutes).
        /// </summary>
        public long AsyncResponseTimeout { get; set; }

        /// <summary>
        /// Array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics.
        /// </summary>
        public List<FetchExternalTaskTopic> Topics { get; set; }
    }
}
