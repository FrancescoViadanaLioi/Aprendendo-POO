using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX19.Entities;
using EX19.Entities.Enum;

namespace EX19.Controllers
{
    internal class ConsoleUI
    {
        public static void ShowError(string text)
        {
            ShowMessage(new Message(text, MessageKind.Error, pause: true));
        }
        public static void ShowInfo(string text)
        {
            ShowMessage(new Message(text, MessageKind.Info, pause: true));
        }
        private static void ShowMessage(Message message)
        {
            string prefix = message.Kind.ToString().ToUpper();
            Console.WriteLine($"{prefix}: {message.Text}");

            if (message.Pause)
            {
                Console.WriteLine("(Press any key to continue)");
            }
        }
    }
}
