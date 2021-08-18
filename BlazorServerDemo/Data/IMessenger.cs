using System;
using System.Collections.Generic;

namespace BlazorServerDemo.Data
{
    public interface IMessenger
    {
        event EventHandler Updated;
        List<KeyValuePair<string, string>> Messages { get; set; }
        void SendMessage(string user, string message);
    }
}