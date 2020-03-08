﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.AzureQueueLibrary.Infrustructure
{
    public class QueueConfig
    {
        public string QueueConnectionString { get; set; }

        public QueueConfig()
        {

        }

        public QueueConfig(string queueConnectionString)
        {
            QueueConnectionString = queueConnectionString;
        }
    }
}
