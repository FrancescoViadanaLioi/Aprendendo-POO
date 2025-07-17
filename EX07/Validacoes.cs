using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Validacoes
{
    public static class Validations
    {
        public static bool NomeEhValido(string? nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) return false;
            return Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$");
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