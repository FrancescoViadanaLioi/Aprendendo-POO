using System;
using System.Globalization;

namespace UniversalResources
{
    public static class RequisicoesDeDados
    {
        public static string? EntrarComInput(string msg)
        {
            Console.Write(msg);
            string? input = Console.ReadLine();
            return input;
        }
    }
    public static class FormatadorDecimal
    {
        public static string Formatar(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}