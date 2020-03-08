using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.AzureQueueLibrary.Messages
{
    public abstract class BaseQueueMessage
    {
        public string Route { get; set; }
        public BaseQueueMessage(string route)
        {
            Route = route;
        }
    }
}
