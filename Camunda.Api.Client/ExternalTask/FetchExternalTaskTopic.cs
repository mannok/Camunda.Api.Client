using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class FetchExternalTaskTopic
    {
        /// <param name="topicName">The topic's name.</param>
        /// <param name="lockDuration">The duration to lock the external tasks for in milliseconds.</param>
        public FetchExternalTaskTopic(string topicName, long lockDuration)
        {
            TopicName = topicName;
            LockDuration = lockDuration;
        }

        /// <summary>
        ///  A String value which enables the filtering of tasks based on process instance business key.
        /// </summary>
        public string BusinessKey { get; set; }

        /// <summary>
        /// Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default false).
        /// </summary>
        public bool DeserializeValues { get; set; }

        /// <summary>
        /// If true only local variables will be fetched.
        /// </summary>
        public bool LocalVariables { get; set; }

        /// <summary>
        /// The duration to lock the external tasks for in milliseconds.
        /// </summary>
        public long LockDuration { get; set; }

        /// <summary>
        /// Filter tasks based on process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter tasks based on process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter tasks based on process definition key.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Filter tasks based on process definition keys.
        /// </summary>
        [JsonProperty("processDefinitionKeyIn")]
        public List<string> ProcessDefinitionKeys { get; set; } = new List<string>();

        /// <summary>
        /// A map of variables used for filtering tasks based on process instance variable values.
        /// </summary>
        public Dictionary<string, object> ProcessVariables = new Dictionary<string, object>();

        /// <summary>
        /// Filter tasks based on tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();

        /// <summary>
        /// The topic's name
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Array of String values that represent variable names.
        /// For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task's execution.
        /// </summary>
        public List<string> Variables { get; set; }

        /// <summary>
        /// Filter tasks without tenant id.
        /// </summary>
        public bool WithoutTenantId { get; set; }

        public override string ToString() => TopicName;
    }
}