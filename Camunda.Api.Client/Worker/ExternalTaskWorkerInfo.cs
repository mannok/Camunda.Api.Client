using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Worker
{
    public class ExternalTaskWorkerInfo
    {
        public Type Type { get; set; }

        public string ProcessId { get; set; }
        public string ActivityId { get; set; }

        public int Retries { get; set; }
        public long RetryTimeout { get; set; }
        public List<string> VariablesToFetch { get; set; }

        public IExternalTaskAdapter TaskAdapter { get; set; }
    }
}
