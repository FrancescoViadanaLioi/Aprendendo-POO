using System;
using System.Globalization;
using EX26.Services;
using EX26.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Console.Write("Type how many products will be analyzed: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter with the products name and price, following this model: 'name','price'");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}° Product: ");
            string[] vect = Console.ReadLine()!.Split(',');
            string name = vect[0];
            double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

            Product product = new Product(name, price);
            products.Add(product);
        }

        Console.WriteLine();

        Product highestPrice = CalculationService.Max(products);

        Console.WriteLine("Product with the highest price:");
        Console.WriteLine(highestPrice.ToString());
    }
}