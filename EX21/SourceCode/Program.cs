using EX21.Entities;
using EX21.Entities.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Kriptonian superman = new Kriptonian("Superman", "Clark Kent");
        superman.SuperStrength();
        superman.Flight();
        superman.SuperSpeed();
        superman.ShowSecretIdentity();

        Kriptonian zod = new Kriptonian("General Zod");
        zod.ShowSecretIdentity();

    }
}