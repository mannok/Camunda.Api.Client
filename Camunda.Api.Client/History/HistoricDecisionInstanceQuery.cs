﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceQuery : QueryParameters
    {
        /// <summary>
        /// Filter by decision instance id.
        /// </summary>
        public string DecisionInstanceId { get; set; }

        /// <summary>
        /// Filter by decision instance ids.
        /// </summary>
        [JsonProperty("decisionInstanceIdIn")]
        public List<string> DecisionInstanceIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter by the decision definition the instances belongs to.
        /// </summary>
        public string DecisionDefinitionId { get; set; }

        /// <summary>
        /// Filter by the decision definitions the instances belongs to.
        /// </summary>
        [JsonProperty("decisionDefinitionIdIn")]
        public List<string> DecisionDefinitionIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter by the key of the decision definition the instances belongs to.
        /// </summary>
        public string DecisionDefinitionKey { get; set; }

        /// <summary>
        /// Filter by the keys of the decision definition the instances belongs to.
        /// </summary>
        [JsonProperty("decisionDefinitionKeyIn")]
        public List<string> DecisionDefinitionKeys { get; set; } = new List<string>();

        /// <summary>
        /// Filter by the name of the decision definition the instances belongs to.
        /// </summary>
        public string DecisionDefinitionName { get; set; }

        /// <summary>
        /// Filter by the process definition the instances belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by the key of the process definition the instances belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Filter by the process instance the instances belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by the case definition the instances belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// Filter by the key of the case definition the instances belongs to.
        /// </summary>
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// Filter by the case instance the instances belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// Filter by the activity ids the instances belongs to.
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter by the activity instance ids the instances belongs to.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds { get; set; } = new List<string>();

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A historic decision instance must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();

        /// <summary>
        /// Restrict to instances that were evaluated before the given date.
        /// </summary>
        public DateTime? EvaluatedBefore { get; set; }

        /// <summary>
        /// Restrict to instances that were evaluated after the given date.
        /// </summary>
        public DateTime? EvaluatedAfter { get; set; }

        /// <summary>
        /// Restrict to instances that were evaluated by the given user.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Include input values in the result. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool IncludeInputs = false;

        /// <summary>
        /// Include output values in the result. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool IncludeOutputs = false;

        /// <summary>
        /// Disables fetching of byte array input and output values. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DisableBinaryFetching = false;

        /// <summary>
        /// Disables deserialization of input and output values that are custom objects. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DisableCustomObjectDeserialization = false;

        /// <summary>
        /// Restrict to instances that have a given root decision instance id. This also includes the decision instance with the given id.
        /// </summary>
        public string RootDecisionInstanceId { get; set; }

        /// <summary>
        /// Restrict to instances those are the root decision instance of an evaluation.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool RootDecisionInstancesOnly = false;

        /// <summary>
        /// Filter by the decision requirements definition the instances belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionId { get; set; }

        /// <summary>
        /// Filter by the key of the decision requirements definition the instances belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionKey { get; set; }

        /// <summary>
        /// Sort the results by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public HistoricDecisionInstanceQuerySorting SortBy { get; set; }

        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum HistoricDecisionInstanceQuerySorting
    {
        EvaluationTime,
        TenantId
    }
}