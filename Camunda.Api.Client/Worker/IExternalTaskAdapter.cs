using Camunda.Api.Client.ExternalTask;
using System.Collections.Generic;

namespace Camunda.Api.Client.Worker
{

    public interface IExternalTaskAdapter
    {
        Dictionary<string, VariableValue> Execute(LockedExternalTask externalTask);
    }
}
