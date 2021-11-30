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
        public WorkerService workerService { get; set; }

        [OneTimeSetUp]
        public async Task Setup()
        {
            camundaClient = CamundaClient.Create("http://192.168.17.158:39090/engine-rest");

            // deploy BPMN
            var pdDeployment = await camundaClient.Deployments.Create(
                "CamundaEngineLibraryTest",
                new ResourceDataContent(File.OpenRead($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\BPMN\CamundaEngineLibraryTest.bpmn"), "CamundaEngineLibraryTest.bpmn")
            );

            var pdDeploymentID = pdDeployment.Id;

            TargetProcessDefinitionInfo = (await camundaClient.ProcessDefinitions.Query(new ProcessDefinitionQuery()
            {
                DeploymentId = pdDeploymentID
            }).List()).Single();

            workerService = new WorkerService(camundaClient, Assembly.GetExecutingAssembly());
            workerService.StartupWithSingleThreadPolling();
        }

        [OneTimeTearDown]
        public async Task Cleanup()
        {
            await camundaClient.Deployments[TargetProcessDefinitionInfo.DeploymentId].Delete(true);
        }

        [Test, Order(1)]
        public async Task TestStartupWithSingleThreadPolling()
        {
            var piInfo = await camundaClient.ProcessDefinitions[TargetProcessDefinitionInfo.Id].StartProcessInstance(new StartProcessInstance() { });

            System.Threading.Thread.Sleep(10000);

            var hpi = (await camundaClient.History.ProcessInstances.Query(new HistoricProcessInstanceQuery() { ProcessInstanceId = piInfo.Id }).List()).SingleOrDefault();

            Assert.IsNotNull(hpi, "process instance cannot be processed by agent");
        }

        [Test, Order(2)]
        public async Task StressTest()
        {
            var piInfos = await Task.WhenAll(Enumerable.Range(0, 30).AsParallel().Select(x =>
                camundaClient.ProcessDefinitions[TargetProcessDefinitionInfo.Id].StartProcessInstance(new StartProcessInstance() { })
            ).ToArray());

            System.Threading.Thread.Sleep(50000);

            var hpis = await camundaClient.History.ProcessInstances.Query(new HistoricProcessInstanceQuery()
            {
                ProcessInstanceIds = piInfos.Select(x => x.Id).ToList()
            }).List();

            Assert.IsTrue(piInfos.Length == hpis.Count(), "stress test not pass");
        }
    }
}
