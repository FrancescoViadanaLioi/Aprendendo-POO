using System;
using EX21.Entities.Interfaces;

namespace EX21.Entities
{
    internal class Kriptonian: IPowers
    {
        public string Name { get; private set; }
        public string? SecretIdentity { get; private set; } = null;

        public Kriptonian(string name)
        {
            Name = name;
        }
        public Kriptonian(string name, string secretIdentity): this(name)
        {
            SecretIdentity = secretIdentity;
        }

        public void HeatVision()
        {
            Activate("Heat Vision");
        }
        public void FreezingBreath()
        {
            Activate("Freezing Breath");
        }
        public void Flight()
        {
            Console.WriteLine($"Is it a bird? Is it a plane? No... it's {this.Name}!");
        }
        public void SuperStrength()
        {
            Activate("Super strength");
        }
        public void XRayVision()
        {
            Activate("X-Ray Vision");
        }
        public void SuperSpeed()
        {
            Console.WriteLine($"Faster than a speeding bullet: it's {this.Name}!");
        }
        private void Activate(string power)
        {
            Console.WriteLine($"{this.Name} is using {power}!");
        }
    }
}
