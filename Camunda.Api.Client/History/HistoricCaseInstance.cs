using System;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstance
    {
        /// <summary>
        /// The id of the case instance.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// If true, this case instance is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// The business key of the case instance.
        /// </summary>
        public string BusinessKey { get; set; }

        /// <summary>
        /// The id of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The key of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The name of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionName { get; set; }

        /// <summary>
        /// If true, this case instance is closed.
        /// </summary>
        public bool Closed { get; set; }

        /// <summary>
        /// The time the instance was closed. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime CloseTime { get; set; }

        /// <summary>
        /// If true, this case instance is completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The time the instance was created. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// The id of the user who created the case instance.
        /// </summary>
        public string CreateUserId { get; set; }

        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public int DurationInMillis { get; set; }

        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string SuperCaseInstanceId { get; set; }

        /// <summary>
        /// The id of the parent process instance, if it exists.
        /// </summary>
        public string SuperProcessInstanceId { get; set; }

        /// <summary>
        /// The tenant id of the case instance.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// If true, this case instance is terminated.
        /// </summary>
        public bool Terminated { get; set; }

        public override string ToString() => Id;
    }
}