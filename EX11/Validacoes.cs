using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Validations
{
    public static class ValidacoesDeDados
    {
        public static bool ValidarNome(string input)
        {
            string padrao = @"^[A-Za-zÀ-ÖØ-öø-ÿ]+(?:[ -][A-Za-zÀ-ÖØ-öø-ÿ]+)*$";
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, padrao) && input.Length > 1;
        }
    }
}