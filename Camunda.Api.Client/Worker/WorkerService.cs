using Camunda.Api.Client.ExternalTask;
using Camunda.Api.Client.Worker;
using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Camunda.Api.Client
{
    public class WorkerService
    {

        private ILog logger = LogManager.GetLogger(typeof(WorkerService));

        private ExternalTaskListener _listener;
        private IList<ExternalTaskWorker> _workers = new List<ExternalTaskWorker>();
        //private CamundaClientHelper _camundaClientHelper;
        private ExternalTaskService _externalTaskService;
        private Assembly _entryAssembly;

        public WorkerService(ExternalTaskService externalTaskService, Assembly entryAssembly)
        {
            _externalTaskService = externalTaskService;
            _entryAssembly = entryAssembly;
        }

        /// <summary>
        /// Startup the 
        /// </summary>
        public void StartupWithSingleThreadPolling()
        {
            logger.Info("call StartupWithSingleThreadPolling");
            this.StartWorkerListener();
        }

        public void ShutdownSingleThreadPolling()
        {
            logger.Info("call ShutdownSingleThreadPolling");
            this.StopWorkerListener();
        }

        public void StartWorkerListener()
        {
            Assembly assembly = _entryAssembly ?? Assembly.GetEntryAssembly();
            var externalTaskWorkers = RetrieveExternalTaskWorkerInfo(assembly);

            CheckWorkers(externalTaskWorkers);

            _listener = new ExternalTaskListener(_externalTaskService, externalTaskWorkers);
            _listener.StartWork();
        }


        public void StopWorkerListener()
        {
            _listener.StopWork();
        }

        private static IEnumerable<ExternalTaskWorkerInfo> RetrieveExternalTaskWorkerInfo(Assembly assembly)
        {
            // find all classes with CustomAttribute [ExternalTask("name")]
            var externalTaskTypes = assembly.GetTypes().Where(type => type.GetCustomAttributes(typeof(ExternalTaskAttribute), true).Length > 0).ToArray();

            var workInfos = new List<ExternalTaskWorkerInfo>();

            foreach (var externalTaskType in externalTaskTypes)
            {
                var externalTaskAttributes = externalTaskType.GetCustomAttributes(typeof(ExternalTaskAttribute), true) as ExternalTaskAttribute[];
                var externalTaskVariableRequirementsAttributes = externalTaskType.GetCustomAttributes(typeof(ExternalTaskVariableRequirementsAttribute), true) as ExternalTaskVariableRequirementsAttribute[];

                foreach (var externalTaskAttributeObject in externalTaskAttributes)
                {
                    var externalTaskAttribute = externalTaskAttributeObject;
                    var workInfo = new ExternalTaskWorkerInfo();
                    workInfo.Type = externalTaskType;
                    workInfo.TaskAdapter = externalTaskType.GetConstructor(Type.EmptyTypes)?.Invoke(null) as IExternalTaskAdapter;
                    workInfo.ProcessId = externalTaskAttribute.ProcessId;
                    workInfo.ActivityId = externalTaskAttribute.ActivityId;
                    workInfo.Retries = externalTaskAttribute.Retries;
                    workInfo.RetryTimeout = externalTaskAttribute.RetryTimeout;
                    workInfo.VariablesToFetch = externalTaskVariableRequirementsAttributes?.Where(x => x.VariablesToFetch != null).SelectMany(x => x.VariablesToFetch).ToList();
                    workInfos.Add(workInfo);
                }
            }

            return workInfos;
        }

        public void CheckWorkers(IEnumerable<ExternalTaskWorkerInfo> workerInfos)
        {

            var groupInfo = workerInfos.GroupBy(c => new { c.ProcessId, c.ActivityId }).Select(g => new { ProcessId = g.Key.ProcessId, ActivityId = g.Key.ActivityId, Count = g.Count() });
            var exceptionInfos = groupInfo.Where(x => x.Count > 1);

            if (exceptionInfos.Count() > 0)
            {
                string message = "";

                foreach (var exceptionInfo in exceptionInfos)
                {
                    var exceptionWorkerAssemblyNamesString = string.Join(@",", workerInfos.Where(x => x.ProcessId == exceptionInfo.ProcessId && x.ActivityId == exceptionInfo.ActivityId).Select(x => x.Type.FullName));
                    message += string.Format(@"The assembly name {0} is configured same process id {1} and same activity id {2}. This library is not support different assembly point to same topic.\n", exceptionWorkerAssemblyNamesString, exceptionInfo.ProcessId, exceptionInfo.ActivityId);
                }

                throw new NotSupportedException(message);
            }
        }

        public void Startup()
        {
            logger.Info("call Startup");
            StartWorkers();

            //    #region autodeploy

            //    Assembly thisExe = Assembly.GetEntryAssembly();
            //    string[] resources = thisExe.GetManifestResourceNames();

            //    if (resources.Length == 0) return;

            //    List<object> files = new List<object>();
            //    foreach (string resource in resources)
            //    {
            //        // TODO Check if Camunda relevant (BPMN, DMN, HTML Forms)

            //        // Read and add to Form for Deployment                
            //        files.Add(FileParameter.FromManifestResource(thisExe, resource));

            //        Console.WriteLine("Adding resource to deployment: " + resource);
            //    }

            //    Deploy(thisExe.GetName().Name, files);

            //    Console.WriteLine("Deployment to Camunda BPM succeeded.");

            //    #endregion
        }

        public void Shutdown()
        {
            StopWorkers();
        }

        public void StartWorkers()
        {
            var assembly = Assembly.GetEntryAssembly();
            var externalTaskWorkers = RetrieveExternalTaskTopicWorkerInfo(assembly);

            foreach (var taskWorkerInfo in externalTaskWorkers)
            {
                Console.WriteLine($"Register Task Worker for Topic '{taskWorkerInfo.TopicName}'");
                var worker = new ExternalTaskWorker(_externalTaskService, taskWorkerInfo);
                _workers.Add(worker);
                worker.StartWork();
            }
        }

        private static IEnumerable<ExternalTaskTopicWorkerInfo> RetrieveExternalTaskTopicWorkerInfo(Assembly assembly)
        {
            // find all classes with CustomAttribute [ExternalTask("name")]
            var externalTaskWorkers =
                from t in assembly.GetTypes()
                let externalTaskTopicAttribute = t.GetCustomAttributes(typeof(ExternalTaskTopicAttribute), true).FirstOrDefault() as ExternalTaskTopicAttribute
                let externalTaskVariableRequirements = t.GetCustomAttributes(typeof(ExternalTaskVariableRequirementsAttribute), true).FirstOrDefault() as ExternalTaskVariableRequirementsAttribute
                where externalTaskTopicAttribute != null
                select new ExternalTaskTopicWorkerInfo
                {
                    Type = t,
                    TopicName = externalTaskTopicAttribute.TopicName,
                    Retries = externalTaskTopicAttribute.Retries,
                    RetryTimeout = externalTaskTopicAttribute.RetryTimeout,
                    VariablesToFetch = externalTaskVariableRequirements?.VariablesToFetch,
                    TaskAdapter = t.GetConstructor(Type.EmptyTypes)?.Invoke(null) as IExternalTaskAdapter
                };

            return externalTaskWorkers;
        }

        public void StopWorkers()
        {
            foreach (ExternalTaskWorker worker in _workers)
            {
                worker.StopWork();
            }
        }

        // HELPER METHODS

    }
}
