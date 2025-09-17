using EX19.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19.Entities
{
    internal class Message
    {
        public string Text { get; private set; }
        public MessageKind Kind { get; private set; }
        public bool Pause { get; private set; }

        public Message(string text, MessageKind kind, bool pause)
        {
            Text = text;
            Kind = kind;
            Pause = pause;
        }
    }
}
