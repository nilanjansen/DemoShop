using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.AzureQueueLibrary.MessageSerializer
{
    public interface IMessageSerializer
    {
        T Derialize<T>(string message);
        string Serialize(object obj);
    }
}
