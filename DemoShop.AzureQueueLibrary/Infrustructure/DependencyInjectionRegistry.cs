using System;
using System.Collections.Generic;
using System.Text;
using DemoShop.AzureQueueLibrary.MessageSerializer;
using DemoShop.AzureQueueLibrary.QueueConnection;
using Microsoft.Extensions.DependencyInjection;

namespace DemoShop.AzureQueueLibrary.Infrustructure
{
    public static class DependencyInjectionRegistry
    {
        public static IServiceCollection AddAzureQueueLibrary(
            this IServiceCollection services
          , string queueConnectionString)
        {
            services.AddSingleton(new QueueConfig(queueConnectionString));
            services.AddSingleton<ICloudQueueClientFactory, CloudQueueClientFactory>();
            services.AddSingleton<IMessageSerializer, JsonMessageSerializer>();
            services.AddTransient<IQueueCommunicator, QueueCommunicator>();
            return services;
        }
    }
}
