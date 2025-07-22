using System;
using System.Globalization;

namespace Validations
{
    public static class Validacoes
    {
        public static bool ValidarDecimal(string? input, out double num)
        {
            num = 0;
            if (string.IsNullOrWhiteSpace(input)) return false;
            return double.TryParse(input,NumberStyles.Float, CultureInfo.InvariantCulture ,out num) && num >= 0;
        }
    }
}