using System;
using EX24.Entities;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer("24789");
        Console.WriteLine($"Printer serial number: #{p.SerialNumber}");
        p.ProcessDoc("My letter");
        p.Print("My letter");
        Console.WriteLine();

        Scanner s = new Scanner("01241");
        Console.WriteLine($"Scanner serial number: #{s.SerialNumber}");
        s.ProcessDoc("My E-mail");
        s.Scan();
        Console.WriteLine();

        HybridDevice hD = new HybridDevice("10457");
        Console.WriteLine($"Hybrid device serial number: #{hD.SerialNumber}");
        hD.ProcessDoc("My essay");
        hD.Print("My essay");
        hD.Scan();
    }
}