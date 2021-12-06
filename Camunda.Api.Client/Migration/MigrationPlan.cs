using System.Collections.Generic;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Migration
{
    public class MigrationPlan
    {
        /// <summary>
        /// The id of the source process definition for the migration.
        /// </summary>
        [JsonProperty("sourceProcessDefinitionId")]
        public string SourceProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the target process definition for the migration.
        /// </summary>
        [JsonProperty("targetProcessDefinitionId")]
        public string TargetProcessDefinitionId { get; set; }

        /// <summary>
        /// A list of migration instructions which map equal activities.
        /// </summary>
        [JsonProperty("instructions")]
        public List<MigrationInstruction> Instructions { get; set; }
    }
}
