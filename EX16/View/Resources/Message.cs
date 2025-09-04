using System;
using EX16.View.Resources.ResourcesEnums;

namespace EX16.View.Resources
{
    internal class Message
    {
        public string Text { get; set; }
        public MessageKind Kind { get; set; }
        public bool WaitForInput { get; set; }
        public bool ClearScreen { get; set; }

        public Message(string text, MessageKind kind, bool waitForInput, bool clearScreen)
        {
            Text = text;
            Kind = kind;
            WaitForInput = waitForInput;
            ClearScreen = clearScreen;
        }
    }
}
