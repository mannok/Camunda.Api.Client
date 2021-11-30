using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Worker
{
    public class ExternalTaskTopicWorkerInfo
    {
        public int Retries { get; set; }
        public long RetryTimeout { get; set; }
        public Type Type { get; set; }
        public string TopicName { get; set; }
        public List<string> VariablesToFetch { get; set; }
        public IExternalTaskAdapter TaskAdapter { get; set; }
    }
}
