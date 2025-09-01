using System;

namespace Saida
{
    public static class SaidaDeDados
    {
        public static void ImprimirDadosData(DateTime date)
        {
            Console.WriteLine($"Data original: {date}");
            Console.WriteLine($"Tipo: {date.Kind}");
            Console.WriteLine($"Data para local: {date.ToLocalTime()}");
            Console.WriteLine($"Data para UTC: {date.ToUniversalTime()}");
            Console.WriteLine($"Data para formato ISO 8601: {date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")}");
        }
    }
}