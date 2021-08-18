using System;
using System.Collections.Generic;

namespace BlazorServerDemo.Data
{
    public interface IMessenger
    {
        List<KeyValuePair<string, string>> Messages { get; set; }

        event EventHandler Updated;

        void SendMessage(string user, string message);
    }
}