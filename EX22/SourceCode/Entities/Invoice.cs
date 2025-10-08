using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EX22.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment => BasicPayment + Tax;

        public override string ToString()
        {
            return $"Base Payment: ${BasicPayment.ToString("F2", CultureInfo.InvariantCulture)};\n" +
                $"Tax: ${Tax.ToString("F2", CultureInfo.InvariantCulture)};\n" +
                $"Total Payment: ${TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
