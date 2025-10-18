using EX24.Entities.Interfaces;
using System;
using System.Runtime.CompilerServices;

namespace EX24.Entities
{
    internal class HybridDevice: Device, IScanner, IPrinter
    {
        public HybridDevice(string serialNumber) : base(serialNumber) { }

        public override void ProcessDoc(string document)
        {
            try
            {
                Console.WriteLine($"Hybrid Device processing {document}");
            }
            catch (NotImplementedException error)
            {
                Console.WriteLine($"ERROR: {error.Message}");
            }
        }

        public void Print(string document)
        {
            Console.WriteLine($"Hybrid Device print {document}");
        }
        
        public void Scan()
        {
            Console.WriteLine("Hybrid Device scan result");
        }
    }
}
