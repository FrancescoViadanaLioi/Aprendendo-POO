using System;
using EX19.Controllers;
using EX19.Entities;
using EX19.View;
using EX19.Services;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>();
        int quantity = ProductInput.QuantityInput();

        for (int i = 1; i <= quantity; i++)
        {
            Console.WriteLine($"Type the Product #{i} ");
            char? option = DataInput.AskForCharInput("Common, used or imported (c/u/i)? ");
            string name = ProductInput.NameInput();
            double price = ProductInput.PriceInput();

            while (true)
            { 
                switch (option)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;

                    case 'u':
                        DateTime manufactureDate = ProductInput.ManufactureDateInput();
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case 'i':
                        double customFee = ProductInput.CustomFeeInput();
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;

                    default:
                        ConsoleUI.ShowError("Invalid option, try again.");
                        break;

                }
                break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("PRICE TAGS");

        foreach (Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}