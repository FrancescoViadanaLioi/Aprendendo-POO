using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX21.Entities
{
    internal class SecretIdentity //Class that check if the character has a secret identity
    {
        public string? Name { get; }
        public bool Exists => !string.IsNullOrWhiteSpace(Name);

        public SecretIdentity(string name)
        {
            Name = string.IsNullOrWhiteSpace(name) ? null : name;
        }
        public override string ToString()
        {
            return Exists ? Name! : "No secret identity.";
        }
    }
}
