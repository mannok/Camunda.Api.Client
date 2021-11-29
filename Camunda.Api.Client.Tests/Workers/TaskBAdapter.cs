using Camunda.Api.Client;
using Camunda.Api.Client.ExternalTask;
using Camunda.Api.Client.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamundaClientLibrary.Test.Workers
{
    [ExternalTask("Process_CamundaEngineLibrary.Test", "Activity_B")]
    public class TaskBAdapter : IExternalTaskAdapter
    {
        public Dictionary<string, VariableValue> Execute(LockedExternalTask externalTask)
        {
            return new Dictionary<string, VariableValue>() { { "Task B Result", VariableValue.FromObject(DateTime.Today.ToLongTimeString()) } };
        }
    }
}
