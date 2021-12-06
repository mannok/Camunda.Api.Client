using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDetail
    {
        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The id of the entry.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// The id of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// The id of the process instance on which the associated job was created.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// The id of the activity instance that the external task belongs to.
        /// </summary>
        public string ActivityInstanceId { get; set; }
        /// <summary>
        /// The execution id on which the associated job was created.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Case definition key
        /// </summary>
        public string CaseDefinitionKey { get; set; }
        /// <summary>
        /// Case definition id
        /// </summary>
        public string CaseDefinitionId { get; set; }
        /// <summary>
        /// Case instance id
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Case execution id
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// Task id
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// The id of the tenant that this historic job log entry belongs to.
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// User operation id
        /// </summary>
        public string UserOperationId { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Variable name
        /// </summary>
        public string VariableName { get; set; }
        /// <summary>
        /// Variable instance id
        /// </summary>
        public string VariableInstanceId { get; set; }
        /// <summary>
        /// Variable type
        /// </summary>
        public string VariableType { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Revision
        /// </summary>
        public string Revision { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Value info
        /// </summary>
        public Dictionary<string, object> ValueInfo;
        /// <summary>
        /// The id of the form field.
        /// </summary>
        public string FieldId { get; set; }
        /// <summary>
        /// The submitted value.
        /// </summary>
        public object FieldValue { get; set; }

        /// <summary>
        /// To string implementation
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Id.ToString();
    }
}
