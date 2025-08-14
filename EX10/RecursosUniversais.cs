using System;
using System.Globalization;

namespace UniversalResources
{
    public static class Requisicao
    {
        public static string? PedirEntrada(string requisicao)
        {
            Console.Write(requisicao);
            string input = Console.ReadLine()!;
            return input.ToString();
        }
    }
    public static class FormatadorDecimal
    {
        public static string Formatar(double numero)
        {
            return numero.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}