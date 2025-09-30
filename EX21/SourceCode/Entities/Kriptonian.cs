using System;
using EX21.Entities.Interfaces;

namespace EX21.Entities
{
    internal class Kriptonian : IPowers
    {
        public string Name { get; private set; }
        public SecretIdentity SecretIdentity { get; private set; }

        public Kriptonian(string name)
        {
            Name = name;
            SecretIdentity = new SecretIdentity(null!);
        }
        public Kriptonian(string name, string secretIdentity) : this(name)
        {
            SecretIdentity = new SecretIdentity(secretIdentity);
        }

        public void HeatVision() => Activate("Heat Vision");
        public void FreezingBreath() => Activate("Freezing Breath");
        public void Flight() => Console.WriteLine($"Is it a bird? Is it a plane? No... it's {Name}!");
        public void SuperStrength() => Activate("Super strength");
        public void XRayVision() => Activate("X-Ray Vision");
        public void SuperSpeed() => Console.WriteLine($"Faster than a speeding bullet: it's {Name}!");
        public void ShowSecretIdentity() => Console.WriteLine($"{Name} secret identity: {SecretIdentity}");

        private void Activate(string power) => Console.WriteLine($"{Name} is using {power}!");
    }
}