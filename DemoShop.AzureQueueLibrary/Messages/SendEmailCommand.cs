using DemoShop.AzureQueueLibrary.Infrustructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.AzureQueueLibrary.Messages
{
    public class SendEmailCommand : BaseQueueMessage
    {
        public string To { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public SendEmailCommand()
            :base(RouteNames.EmailBox)
        {

        }
    }
}
