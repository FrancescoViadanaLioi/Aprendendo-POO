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
        public static bool ValidarPreco(string input, out double precoValidado)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out precoValidado) && precoValidado > 0;
        }
        public static bool ValidarPreco(double input, out double precoValidado)
        {
            precoValidado = 0.00;

            if (input > 0)
            {
                precoValidado = input;
                return true;
            }
            return false;
        }
    }
}