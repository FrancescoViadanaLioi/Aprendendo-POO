using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validacoes
{
    public class Validations
    {
        public static bool NomeEhValido(string? nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$");
        }
        public static bool PrecoEhValido(string? input)
        {
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double preco) && preco >= 0;
        }
    }
}