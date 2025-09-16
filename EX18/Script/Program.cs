using EX18.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account("3000", "Alex", 500);
        Account acc2 = new SavingAccount("3001", "Ana", 500, 00.1);

        acc1.Withdraw(10.00);
        acc2.Withdraw(10.00);

        Console.WriteLine($"{acc1.Holder} balance: ${acc1.Balance}");
        Console.WriteLine($"{acc2.Holder} balance: ${acc2.Balance}");
    }
}