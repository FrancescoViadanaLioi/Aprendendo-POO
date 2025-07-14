using System;
using System.Globalization;

namespace Validacoes
{
    public class Validations
    {
        public static bool ValidarLado(string input)
        {
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double lado);
        }
        public static bool ValidarTriangulo(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a) return false;
            return true;
        }
    }
}