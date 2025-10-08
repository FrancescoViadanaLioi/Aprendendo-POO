using System;
using System.Globalization;
using EX22.Entities;
using EX22.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type the car's model: ");
        string carModel = Console.ReadLine()!;
        Console.Write("Enter with the pickup date (dd/MM/yyyy HH:mm format): ");
        DateTime pickupDay = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Enter with the return date (dd/MM/yyyy HH:mm format): ");
        DateTime returnDay = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Type the price per hour: $");
        double pricePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Type the price per day: $");
        double pricePerDay = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(pickupDay, returnDay, new Vehicle(carModel));

        RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("INVOICE");

        Console.WriteLine(carRental.Invoice.ToString());
    }

}