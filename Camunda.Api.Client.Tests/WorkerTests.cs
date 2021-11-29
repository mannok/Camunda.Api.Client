using Camunda.Api.Client.Deployment;
using Camunda.Api.Client.History;
using Camunda.Api.Client.ProcessDefinition;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Tests
{
    public class WorkerTests
    {
        public CamundaClient camundaClient { get; set; }
        public ProcessDefinitionInfo TargetProcessDefinitionInfo { get; set; }

        [SetUp]
        public void Setup()
        {
            camundaClient = CamundaClient.Create("http://localhost:19090/engine-rest", Assembly.GetExecutingAssembly());

            // deploy BPMN
            var pdDeploymentID = camundaClient.Deployments.Create(
                "CamundaEngineLibraryTest",
                new ResourceDataContent(File.OpenRead($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\BPMN\CamundaEngineLibraryTest.bpmn"), "CamundaEngineLibraryTest.bpmn")
            ).Result.Id;

            TargetProcessDefinitionInfo = camundaClient.ProcessDefinitions.Query(new ProcessDefinitionQuery()
            {
                DeploymentId = pdDeploymentID
            }).List().Result.Single();
        }

        [TearDown]
        public void Cleanup()
        {
            camundaClient.Deployments[TargetProcessDefinitionInfo.DeploymentId].Delete(true).Wait();
        }

        [Test, Order(1)]
        public void TestStartupWithSingleThreadPolling()
        {
            var piInfo = camundaClient.ProcessDefinitions[TargetProcessDefinitionInfo.Id].StartProcessInstance(new StartProcessInstance() { }).Result;

            camundaClient.WorkerService.StartupWithSingleThreadPolling();

            System.Threading.Thread.Sleep(10000);

            var hpi = camundaClient.History.ProcessInstances.Query(new HistoricProcessInstanceQuery() { ProcessInstanceId = piInfo.Id }).List().Result.SingleOrDefault();

            Assert.IsNotNull(hpi, "process instance cannot be processed by agent");
        }

        [Test, Order(2)]
        public void StressTest()
        {
            var piInfos = Task.WhenAll(Enumerable.Range(0, 30).AsParallel().Select(x =>
                camundaClient.ProcessDefinitions[TargetProcessDefinitionInfo.Id].StartProcessInstance(new StartProcessInstance() { })
            ).ToArray()).Result;

            camundaClient.WorkerService.StartupWithSingleThreadPolling();

            System.Threading.Thread.Sleep(50000);

            var hpis = camundaClient.History.ProcessInstances.Query(new HistoricProcessInstanceQuery()
            {
                ProcessInstanceIds = piInfos.Select(x => x.Id).ToList()
            }).List().Result;

            Assert.IsTrue(piInfos.Length == hpis.Count(), "stress test not pass");
        }
    }
}
