using System;

namespace Retangulo
{
    public class Retangle
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public static double CalcularPerimetro(double Largura, double Altura)
        {
            return Largura + Altura;
        }
        public static double CalcularDiagonal(double Largura, double Altura)
        {
            double somaPot = SomarAsPotencias(Largura, Altura);
            return Math.Sqrt(somaPot);
        }
        private static double SomarAsPotencias(double Largura, double Altura)
        {
            return Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
        }
    }
}