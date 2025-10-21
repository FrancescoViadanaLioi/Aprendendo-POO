using System;
using EX24.Entities.Interfaces;

namespace EX24.Entities
{
    internal class Printer : Device, IPrinter
    {
        public Printer(string serialNumber) : base(serialNumber) { }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing {document}");
        }
        public void Print(string document)
        {
            Console.WriteLine($"Printer print {document}");
        }
    }
}
