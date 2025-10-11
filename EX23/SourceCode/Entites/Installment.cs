using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace EX23.Entites
{
    internal class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - ${Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }   
    }
}
