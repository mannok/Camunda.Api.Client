using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskQuery : SortableQuery<HistoricTaskSorting, HistoricTaskQuery>
    {
        /// <summary>
        /// Filter by task id.
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Filter by parent task id.
        /// </summary>
        public string TaskParentTaskId { get; set; }

        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by process instance business key.
        /// </summary>
        [JsonProperty("processInstanceBusinessKey")]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list.
        /// </summary>
        [JsonProperty("ProcessInstanceBusinessKeyIn")]
        public List<string> ProcessInstanceBusinessKeys { get; set; }

        /// <summary>
        /// Filter by process instance business key that has the parameter value as a substring.
        /// </summary>
        [JsonProperty("processInstanceBusinessKeyLike")]
        public string BusinessKeyLike { get; set; }

        /// <summary>
        /// Filter by the id of the execution that executed the task.
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given key.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given name.
        /// </summary>
        public string ProcessDefinitionName { get; set; }

        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// 	Filter by the id of the case execution that executed the task.
        /// </summary>
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given key.
        /// </summary>
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given name.
        /// </summary>
        public string CaseDefinitionName { get; set; }

        /// <summary>
        /// Only include tasks which belong to one of the passed and comma-separated activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds { get; set; }

        /// <summary>
        /// Restrict to tasks that have the given name.
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Restrict to tasks that have a name with the given parameter value as substring.
        /// </summary>
        public string TaskNameLike { get; set; }

        /// <summary>
        /// Restrict to tasks that have the given description.
        /// </summary>
        public string TaskDescription { get; set; }

        /// <summary>
        /// Restrict to tasks that have a description that has the parameter value as a substring.
        /// </summary>
        public string TaskDescriptionLike { get; set; }

        /// <summary>
        /// Restrict to tasks that have the given key.
        /// </summary>
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// Restrict to tasks that have one of the passed and comma-separated task definition keys.
        /// </summary>
        [JsonProperty("taskDefinitionKeyIn")]
        public List<string> TaskDefinitionKeys { get; set; }

        /// <summary>
        /// Restrict to tasks that have the given delete reason.
        /// </summary>
        public string TaskDeleteReason { get; set; }

        /// <summary>
        /// Restrict to tasks that have a delete reason that has the parameter value as a substring.
        /// </summary>
        public string TaskDeleteReasonLike { get; set; }

        /// <summary>
        /// Restrict to tasks that the given user is assigned to.
        /// </summary>
        public string TaskAssignee { get; set; }

        /// <summary>
        /// Restrict to tasks that are assigned to users with the parameter value as a substring.
        /// </summary>
        public string TaskAssigneeLike { get; set; }

        /// <summary>
        /// Restrict to tasks that the given user owns.
        /// </summary>
        public string TaskOwner { get; set; }

        /// <summary>
        /// Restrict to tasks that are owned by users with the parameter value as a substring.
        /// </summary>
        public string TaskOwnerLike { get; set; }

        /// <summary>
        /// Restrict to tasks that have the given priority.
        /// </summary>
        public long? TaskPriority { get; set; }

        /// <summary>
        /// If set to true, restricts the query to all tasks that are assigned.
        /// </summary>
        public bool? Assigned { get; set; }

        /// <summary>
        /// If set to true, restricts the query to all tasks that are unassigned.
        /// </summary>
        public bool? Unassigned { get; set; }

        /// <summary>
        /// Only include finished tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Finished { get; set; }

        /// <summary>
        /// Only include unfinished tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Unfinished { get; set; }

        /// <summary>
        /// Only include tasks of finished processes. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? ProcessFinished { get; set; }

        /// <summary>
        /// Only include tasks of unfinished processes. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? ProcessUnfinished { get; set; }

        /// <summary>
        /// Restrict to tasks that are due on the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDate { get; set; }

        /// <summary>
        /// Restrict to tasks that are due before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDateBefore { get; set; }

        /// <summary>
        /// Restrict to tasks that are due after the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDateAfter { get; set; }

        /// <summary>
        /// Restrict to tasks that have a followUp date on the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDate { get; set; }

        /// <summary>
        /// Restrict to tasks that have a followUp date before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDateBefore { get; set; }

        /// <summary>
        /// Restrict to tasks that have a followUp date after the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDateAfter { get; set; }

        /// <summary>
        /// Restrict to tasks that were started before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Restrict to tasks that were started after the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Restrict to tasks that were finished before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? FinishedBefore { get; set; }

        /// <summary>
        /// Restrict to tasks that were finished after the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? FinishedAfter { get; set; }

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; }

        /// <summary>
        /// Only include historic task instances that belong to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:
        ///A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        ///  Note: Values are always treated as String objects on server side.
        ///Valid operator values are: eq - equal to; neq - not equal to; gt - greater than; gteq - greater than or equal to; lt - lower than; lteq - lower than or equal to; like.
        /// key and value may not contain underscore or comma characters.
        /// </summary>
        public List<VariableQueryParameter> TaskVariables { get; set; }

        /// <summary>
        /// Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:
        ///A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        ///  Note: Values are always treated as String objects on server side.
        ///Valid operator values are: eq - equal to; neq - not equal to; gt - greater than; gteq - greater than or equal to; lt - lower than; lteq - lower than or equal to; like.
        ///key and value may not contain underscore or comma characters.
        /// </summary>
        public List<VariableQueryParameter> ProcessVariables { get; set; }

        /// <summary>
        /// Match the variable name provided in taskVariables and processVariables case-insensitively. If set to true variableName and variablename are treated as equal.
        /// </summary>
        [JsonProperty("variableNamesIgnoreCase")]
        public bool? VariableNamesIgnoreCase { get; set; }

        /// <summary>
        /// Match the variable value provided in taskVariables and processVariables case-insensitively. If set to true variableValue and variablevalue are treated as equal.
        /// </summary>
        [JsonProperty("variableValuesIgnoreCase")]
        public bool? VariableValuesIgnoreCase { get; set; }

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given user
        /// </summary>
        public string TaskInvolvedUser { get; set; }

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given group.
        /// </summary>
        public string TaskInvolvedGroup { get; set; }

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate user.
        /// </summary>
        public string TaskHadCandidateUser { get; set; }

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate group.
        /// </summary>
        public string TaskHadCandidateGroup { get; set; }

        /// <summary>
        /// Only include tasks which have a candidate group. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithCandidateGroups { get; set; }

        /// <summary>
        /// Only include tasks which have no candidate group. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithoutCandidateGroups { get; set; }
    }

    public enum HistoricTaskSorting
    {
        TaskId,
        ActivityInstanceId,
        ProcessDefinitionId,
        ProcessInstanceId,
        ExecutionId,
        Duration,
        EndTime,
        StartTime,
        TaskName,
        TaskDescription,
        Assignee,
        Owner,
        DueDate,
        FollowUpDate,
        DeleteReason,
        TaskDefinitionKey,
        Priority,
        CaseDefinitionId,
        CaseInstanceId,
        CaseExecutionId,
        TenantId
    }
}