using System;
using System.Globalization;

namespace UniversalResources
{
    public static class RequisicaoDeDados
    {
        public static string? PedirEntrada(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
    public static class FormatadorDecimal
    {
        public static string Formatar(double num)
        {
            return num.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}