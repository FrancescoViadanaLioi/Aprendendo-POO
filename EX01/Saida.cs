using System;
using System.Globalization;
using Entrada;

namespace Saida
{
    public static class Exibir
    {
        public static void InfoTriangulo(Triangulo.TrianguloModel t)
        {
            ExibirLado("A", t.A);
            ExibirLado("B", t.B);
            ExibirLado("C", t.C);
            Console.WriteLine($"Perímetro: {t.CalcularPerimetro().ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área: {t.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        private static void ExibirLado(string nome, double valor)
        {
            Console.WriteLine($"Lado {nome}: {valor.ToString(CultureInfo.InvariantCulture)}");
        }

    }
}