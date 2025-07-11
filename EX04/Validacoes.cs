using System;
using System.Text.RegularExpressions;

namespace Validacoes
{
    public class Validations
    {
        public static bool NomeEhValido(string? nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$");
        }
    }
}