using Specky.Attributes;
using System;
using System.Collections.Generic;

namespace BlazorServerDemo.Data
{
    [Speck]
    public class Messenger : IMessenger
    {
        public event EventHandler Updated;
        public List<KeyValuePair<string, string>> Messages { get; set; } = new();

        public void SendMessage(string user, string message)
        {
            Messages.Add(new(user, message));
            Updated?.Invoke(this, EventArgs.Empty);
        }
    }
}
