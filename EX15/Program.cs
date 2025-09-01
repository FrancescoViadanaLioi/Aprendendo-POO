using System;
using EX15.Entities;
using EX15.Entities.Enums;

class Program
{
    static void Main(String[] args)
    {
        DateTime d1 = new DateTime(2025, 08, 29, 15, 46, 32, DateTimeKind.Local);

        Order order = new Order("ABC34", d1, OrderStatus.PendingPayment);

        Console.WriteLine($"{order.Id}, {order.Moment}, {order.Status}");

    }
}