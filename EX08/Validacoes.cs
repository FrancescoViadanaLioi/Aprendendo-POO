using System;

namespace Validations
{
    public static class Validacoes
    {
        public static bool ValidarDecimal(string? input, out double num)
        {
            return double.TryParse(input, out num) && num >= 1;
        }
    }
}