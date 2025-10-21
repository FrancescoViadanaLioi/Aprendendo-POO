using System;
using EX25.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many values will you put in the list (limit is 10 values)? ");
        int vectorSize = int.Parse(Console.ReadLine()!);

        PrintService printService = new PrintService();

        for (int i = 0; i < vectorSize; i++)
        {
            Console.Write($"Value in the position [{i}]: ");
            int value = int.Parse(Console.ReadLine()!);
            printService.AddValue(value);
        }

        printService.Print();
        printService.First();
    }
}