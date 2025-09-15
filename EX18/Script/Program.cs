using EX18.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        BusinessAccount account = new BusinessAccount("4395", "Company", 20000, 15000);

        Console.WriteLine($"Limit: {account.LoanLimit}");
    }
}