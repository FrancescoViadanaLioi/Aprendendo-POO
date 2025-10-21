using System;
using EX24.Entities.Interfaces;

namespace EX24.Entities
{
    internal class Scanner: Device, IScanner
    {
        public Scanner(string serialNumber) : base(serialNumber) { }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner processing {document} ");
        }
        public void Scan()
        {
            Console.WriteLine($"Scanner scan result.");
        }
    }
}
