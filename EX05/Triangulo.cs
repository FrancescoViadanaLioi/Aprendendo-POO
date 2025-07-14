using System;

namespace Triangulo
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
   
    public static double CalcularArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public static double CalcularPerimetro(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}