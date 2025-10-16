using System;

namespace EX24.Entities
{
    internal abstract class Device
    {
        public string SerialNumber { get; private set; }

        public abstract void ProcessDoc(string document);
    }
}
