﻿using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Camunda.Api.Client.UserTask
{
    public class TaskQuery
    {
        /// <summary>
        /// Restrict to tasks that belong to process instances with the given business key.
        /// </summary>
        public string ProcessInstanceBusinessKey { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to process instances with one of the give business keys.
        /// </summary>
        [JsonProperty("processInstanceBusinessKeyIn")]
        public List<string> ProcessInstanceBusinessKeys { get; set; } = new List<string>();
        /// <summary>
        /// Restrict to tasks that have a process instance business key that has the parameter value as a substring.
        /// </summary>
        public string ProcessInstanceBusinessKeyLike { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given key.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a process definition with one of the given keys.
        /// </summary>
        [JsonProperty("processDefinitionKeyIn")]
        public List<string> ProcessDefinitionKeys { get; set; } = new List<string>();
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to an execution with the given id.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Only include tasks which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds { get; set; } = new List<string>();
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given name.
        /// </summary>
        public string ProcessDefinitionName { get; set; }
        /// <summary>
        /// Restrict to tasks that have a process definition name that has the parameter value as a substring.
        /// </summary>
        public string ProcessDefinitionNameLike { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to process instances with the given id.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Restrict to tasks that the given user is assigned to.
        /// </summary>
        public string Assignee { get; set; }
        /// <summary>
        /// Restrict to tasks that the user described by the given expression is assigned to. See the user guide for more information on available functions.
        /// </summary>
        public string AssigneeExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have an assignee that has the parameter value as a substring.
        /// </summary>
        public string AssigneeLike { get; set; }
        /// <summary>
        /// Restrict to tasks that have an assignee that has the parameter value described by the given expression as a substring. See the user guide for more information on available functions.
        /// </summary>
        public string AssigneeLikeExpression { get; set; }
        /// <summary>
        /// Only include tasks that are offered to the given group.
        /// </summary>
        public string CandidateGroup { get; set; }
        /// <summary>
        /// Only include tasks that are offered to the group described by the given expression. See the user guide for more information on available functions.
        /// </summary>
        public string CandidateGroupExpression { get; set; }
        /// <summary>
        /// Only include tasks that are offered to the given user.
        /// </summary>
        public string CandidateUser { get; set; }
        /// <summary>
        /// Only include tasks that are offered to the user described by the given expression. See the user guide for more information on available functions.
        /// </summary>
        public string CandidateUserExpression { get; set; }
        /// <summary>
        /// Also include tasks that are assigned to users in candidate queries. Default is to only include tasks that are not assigned to any user if you query by candidate user or group(s).
        /// </summary>
        public bool? IncludeAssignedTasks { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given key.
        /// </summary>
        public string TaskDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that have one of the given keys.
        /// </summary>
        [JsonProperty("taskDefinitionKeyIn")]
        public List<string> TaskDefinitionKeys { get; set; } = new List<string>();
        /// <summary>
        /// Restrict to tasks that have a key that has the parameter value as a substring.
        /// </summary>
        public string TaskDefinitionKeyLike { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Restrict to tasks that have a description that has the parameter value as a substring.
        /// </summary>
        public string DescriptionLike { get; set; }
        /// <summary>
        /// Only include tasks that the given user is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee).
        /// </summary>
        public string InvolvedUser { get; set; }
        /// <summary>
        /// Only include tasks that the user described by the given expression is involved in. A user is involved in a task if an identity link exists between task and user (e.g., the user is the assignee). See the user guide for more information on available functions.
        /// </summary>
        public string InvolvedUserExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have a lower or equal priority.
        /// </summary>
        public int? MaxPriority { get; set; }
        /// <summary>
        /// Restrict to tasks that have a higher or equal priority.
        /// </summary>
        public int? MinPriority { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Restrict to tasks that have a name with the given parameter value as substring.
        /// </summary>
        public string NameLike { get; set; }
        /// <summary>
        /// Restrict to tasks that the given user owns.
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// Restrict to tasks that the user described by the given expression owns. See the user guide for more information on available functions.
        /// </summary>
        public string OwnerExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given priority.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// Restrict query to all tasks that are sub tasks of the given task. Takes a task id
        /// </summary>
        public string ParentTaskId { get; set; }
        /// <summary>
        /// If set to true, restricts the query to all tasks that are unassigned.
        /// </summary>
        public bool? Unassigned { get; set; }
        /// <summary>
        /// If set to true, restricts the query to all tasks that are assigned.
        /// </summary>
        public bool? Assigned { get; set; }
        /// <summary>
        /// Only include active tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Active { get; set; }
        /// <summary>
        /// Only include suspended tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Suspended { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given key.
        /// </summary>
        public string CaseDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given id.
        /// </summary>
        public string CaseDefinitionId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given name.
        /// </summary>
        public string CaseDefinitionName { get; set; }
        /// <summary>
        /// Restrict to tasks that have a case definition name that has the parameter value as a substring.
        /// </summary>
        public string CaseDefinitionNameLike { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to case instances with the given id.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to case instances with the given business key.
        /// </summary>
        public string CaseInstanceBusinessKey { get; set; }
        /// <summary>
        /// Restrict to tasks that have a case instance business key that has the parameter value as a substring.
        /// </summary>
        public string CaseInstanceBusinessKeyLike { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case execution with the given id.
        /// </summary>
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// Restrict to tasks that are due after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? DueAfter { get; set; }
        /// <summary>
        /// Restrict to tasks that are due after the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string DueAfterExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that are due before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? DueBefore { get; set; }
        /// <summary>
        /// Restrict to tasks that are due before the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string DueBeforeExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that are due on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Restrict to tasks that are due on the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string DueDateExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? FollowUpAfter { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date after the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string FollowUpAfterExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? FollowUpBefore { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date before the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string FollowUpBeforeExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have no followUp date or a followUp date before the given date. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public DateTime? FollowUpBeforeOrNotExistent { get; set; }
        /// <summary>
        /// Restrict to tasks that have no followUp date or a followUp date before the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string FollowUpBeforeOrNotExistentExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? FollowUpDate { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date on the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string FollowUpDateExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that were created after the given date.
        /// </summary>
        public DateTime? CreatedAfter { get; set; }
        /// <summary>
        /// Restrict to tasks that were created after the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string CreatedAfterExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that were created before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? CreatedBefore { get; set; }
        /// <summary>
        /// Restrict to tasks that were created before the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string CreatedBeforeExpression { get; set; }
        /// <summary>
        /// Restrict to tasks that were created on the given date.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Restrict to tasks that were created on the date described by the given expression. See the user guide for more information on available functions. The expression must evaluate to a java.util.Date or org.joda.time.DateTime object.
        /// </summary>
        public string CreatedOnExpression { get; set; }

        /// <summary>
        /// Restrict to tasks that are in the given delegation state.
        /// </summary>
        public DelegationState? DelegationState { get; set; }

        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds { get; set; } = new List<string>();
        /// <summary>
        /// Only include tasks which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Restrict to tasks that are offered to any of the given candidate groups.
        /// </summary>
        public List<string> CandidateGroups { get; set; }
        /// <summary>
        /// Restrict to tasks that are offered to any of the candidate groups described by the given expression. See the user guide for more information on available functions. The expression must evaluate to java.util.List of Strings.
        /// </summary>
        public string CandidateGroupsExpression { get; set; }

        /// <summary>
        /// Array to only include tasks that have variables with certain values. 
        /// </summary>
        public List<VariableQueryParameter> TaskVariables { get; set; } = new List<VariableQueryParameter>();
        /// <summary>
        /// Array to only include tasks that belong to a process instance with variables with certain values.
        /// </summary>
        public List<VariableQueryParameter> ProcessVariables { get; set; } = new List<VariableQueryParameter>();
        /// <summary>
        /// Only include tasks that belong to case instances that have variables with certain values.
        /// </summary>
        public List<VariableQueryParameter> CaseInstanceVariables { get; set; } = new List<VariableQueryParameter>();

        /// <summary>
        /// Only include tasks which have a candidate group.
        /// </summary>
        public bool? WithCandidateGroups { get; set; }
        /// <summary>
        /// Only include tasks which have no candidate group.
        /// </summary>
        public bool? WithoutCandidateGroups { get; set; }

        /// <summary>
        /// Array of criteria to sort the result by. The position in the array identifies the rank of an ordering, i.e. whether it is primary, secondary, etc.
        /// </summary>
        public List<SortingInfo<TaskSorting>> Sorting { get; set; } = new List<SortingInfo<TaskSorting>>();

        /// <param name="sortBy"></param>
        /// <param name="sortOrder"></param>
        /// <param name="variable">
        /// Mandatory when <paramref name="sortBy" /> is either 
        /// <see cref="TaskSorting.ProcessVariable"/>, <see cref="TaskSorting.ExecutionVariable"/>, <see cref="TaskSorting.TaskVariable"/>, <see cref="TaskSorting.CaseExecutionVariable"/> or <see cref="TaskSorting.CaseInstanceVariable"/>
        /// </param>
        public TaskQuery Sort(TaskSorting sortBy, SortOrder sortOrder = SortOrder.Ascending, VariableOrder variable = null)
        {
            Dictionary<string, object> parameters = null;

            TaskSorting[] variableSorting = new[] {
                TaskSorting.ProcessVariable,
                TaskSorting.ExecutionVariable,
                TaskSorting.TaskVariable,
                TaskSorting.CaseExecutionVariable,
                TaskSorting.CaseInstanceVariable
            };

            bool isVariableSorting = variableSorting.Contains(sortBy);

            if (isVariableSorting ^ variable != null)
                throw new ArgumentException("Variable is mandatory when sortBy is either processVariable, executionVariable, taskVariable, caseExecutionVariable or caseInstanceVariable.", nameof(variable));

            if (variable != null) {
                parameters = new Dictionary<string, object>() {
                    ["variable"] = variable.VariableName,
                    ["type"] = variable.Type.ToString(),
                };
            }

            Sorting.Add(new SortingInfo<TaskSorting>() { SortBy = sortBy, SortOrder = sortOrder, Parameters = parameters });

            return this;
        }
    }

    public enum TaskSorting
    {
        Id,
        InstanceId,
        CaseInstanceId,
        DueDate,
        ExecutionId,
        CaseExecutionId,
        Assignee,
        Created,
        Description,
        Name,
        NameCaseInsensitive,
        Priority,

        ProcessVariable,
        ExecutionVariable,
        TaskVariable,
        CaseExecutionVariable,
        CaseInstanceVariable
    }

}
