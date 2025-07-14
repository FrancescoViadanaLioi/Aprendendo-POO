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
    }
}