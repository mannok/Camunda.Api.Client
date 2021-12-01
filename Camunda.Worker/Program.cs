using Camunda.Api.Client;
using System;
using System.Reflection;

namespace Camunda.Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the camunda client to listen the external task for the execution.");
            var camundaEngineClient = new WorkerService("http://192.168.17.158:39090/engine-rest", Assembly.GetExecutingAssembly());
            camundaEngineClient.StartupWithSingleThreadPolling();
            Console.WriteLine("Press any key to stop the client");
            Console.ReadKey();
            camundaEngineClient.StopWorkerListener();
        }
    }
}
