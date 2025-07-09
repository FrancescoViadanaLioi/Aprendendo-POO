using System;

namespace Triangulo
{
    public class TrianguloModel
    {
        public double A;
        public double B;
        public double C;


        public bool EhValido()
        {
            return A > 0 && B > 0 && C > 0 &&
                A < B + C && B < A + C && C < A + B;
        }
        public double CalcularPerimetro()
        {
            return A + B + C;
        }
        public double CalcularArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}