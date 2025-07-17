using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Validacoes
{
    public static class Validations
    {
        public static bool NomeEhValido(string? input, out string? nome)
        {
            nome = string.Empty;

            if (!string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[A-Za-zÀ-ÿ\s]+$"))
            {
                nome = input;
                return true;
            }
            return false;
        }
        public static bool SalarioEhValido(string? input, out double salario)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out salario) && salario >= 1500;
        }
        public static bool ImpostoEhValido(string? input, out double imposto)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out imposto) && imposto >= 0;
        }
    }
}