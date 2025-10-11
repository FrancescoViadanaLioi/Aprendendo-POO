using System;
using EX23.Entites;
using EX23.Services;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data:");
        Console.Write("Enter with the contract's ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter with date(dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract's value: $");
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Contract contract = new Contract(id, date, value);
        Console.WriteLine();
        Console.Write("Contract installments: ");
        int months = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ContractService contractService = new ContractService(new PaypalPaymentService());

        contractService.ProcessContract(contract, months);

        Console.WriteLine("Installments:");
        foreach (Installment intallment in contract.Installments)
        {
            Console.WriteLine(intallment);
        }

    }
}