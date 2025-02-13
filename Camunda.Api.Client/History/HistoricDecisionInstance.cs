﻿using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstance
    {
        /// <summary>
        /// The id of the decision instance.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The id of the decision definition that this decision instance belongs to.
        /// </summary>
        public string DecisionDefinitionId { get; set; }

        /// <summary>
        /// The key of the decision definition that this decision instance belongs to.
        /// </summary>
        public string DecisionDefinitionKey { get; set; }

        /// <summary>
        /// The name of the decision definition that this decision instance belongs to.
        /// </summary>
        public string DecisionDefinitionName { get; set; }

        /// <summary>
        /// The time the instance was evaluated.
        /// </summary>
        public DateTime? EvaluationTime { get; set; }

        /// <summary>
        /// The id of the process definition that this decision instance belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition that this decision instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process instance that this decision instance belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the case definition that this decision instance belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The key of the case definition that this decision instance belongs to.
        /// </summary>
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case instance that this decision instance belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The id of the activity that this decision instance belongs to.
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// The id of the activity instance that this decision instance belongs to.
        /// </summary>
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The tenant id of the historic decision instance.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// The id of the authenticated user that has evaluated this decision instance without a process or case instance.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The list of decision input values. Only exists if <see cref="HistoricDecisionInstanceQuery.IncludeInputs"/> was set to true in the query. For the decision input properties see <see cref="HistoricDecisionInstanceInputValue"/>.
        /// </summary>
        public List<HistoricDecisionInstanceInputValue> Inputs { get; set; }

        /// <summary>
        /// The list of decision output values.Only exists if <see cref="HistoricDecisionInstanceQuery.IncludeOutputs"/> was set to true in the query. For the decision output properties see <see cref="HistoricDecisionInstanceOutputValue"/>.
        /// </summary>
        public List<HistoricDecisionInstanceOutputValue> Outputs { get; set; }

        /// <summary>
        /// The result of the collect aggregation of the decision result if used. null if no aggregation was used.
        /// </summary>
        public double? CollectResultValue { get; set; }
    }
}