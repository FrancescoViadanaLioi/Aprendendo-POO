using System;
using System.Reflection.Metadata;

namespace Dinheiro
{
    public class Money
    {
        public double Aporte { get; set; }
        public double CotacaoDolar { get; set; }

        public double ConverterDolar(double cotDolar)
        {
            return Aporte * cotDolar;
        }
    }
}