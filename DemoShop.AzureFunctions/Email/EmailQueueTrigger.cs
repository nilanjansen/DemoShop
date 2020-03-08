using System;
using System.Threading.Tasks;
using DemoShop.AzureFunctions.Infrustructure;
using DemoShop.AzureQueueLibrary.Infrustructure;
using DemoShop.AzureQueueLibrary.QueueConnection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using DemoShop.AzureQueueLibrary.Messages;

namespace DemoShop.AzureFunctions.Email
{
    public static class EmailQueueTrigger
    {
        [FunctionName("EmailQueueTrigger")]
        public static async Task Run
            ([QueueTrigger(RouteNames.EmailBox, Connection = "AzureWebJobsStorage")]
                string message, 
                ILogger log)
        {
            try
            {
                var queueCommunicator = DIContainer.Instance.GetService<IQueueCommunicator>();
                var command = queueCommunicator.Read<SendEmailCommand>(message);
                var handler = DIContainer.Instance.GetService<ISendEmailCommandHandler>();
                await handler.Handle(command);
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"Something went wrong in Email Queue Trigger {message}");
               throw;
            }
        }
    }
}
