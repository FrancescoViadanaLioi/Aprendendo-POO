using System;

namespace Validations
{
    public static class Validacoes
    {
        public static bool ValidarDecinal(string? input, double num)
        {
            return double.TryParse(input, out num);
        }
    }
}