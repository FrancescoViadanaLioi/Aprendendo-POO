using System;
using System.Globalization;
using System.ComponentModel;
using Saida;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Parse("2007-02-01T22:00:00Z");
        DateTime d2 = DateTime.Parse("2007-08-09 22:00:00");

        SaidaDeDados.ImprimirDadosData(d1);
        Console.WriteLine();
        SaidaDeDados.ImprimirDadosData(d2);
    }

    private static string Formatar(double num)
    {
        return num.ToString("F2", CultureInfo.InvariantCulture);
    }

}
