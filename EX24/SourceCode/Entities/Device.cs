using System;
using System.Globalization;

namespace EX24.Entities
{
    internal abstract class Device
    {
        public string SerialNumber { get; private set; }

        public Device(string serialNumber)
        {
            SerialNumber = serialNumber;
        }
        public abstract void ProcessDoc(string document);
    }
}
