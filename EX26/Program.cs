using System;
using EX26.Services;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        Console.Write("Type how many numbers your list will contain: ");

        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Type the number of the {i + 1}° position: ");
            int x = int.Parse(Console.ReadLine()!);
            list.Add(x);
        }
        Console.WriteLine();

        Console.WriteLine($"The greatest element: {CalculationService.Max(list)}");
    }
}