using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validations
{
    public static class Validacoes
    {
        public static bool ValidarNome(string? input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[A-Za-zÀ-ÿ\s]+$") && input.Length > 1;
        }
        public static bool ValidarPreco(string? input, out double preco)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out preco) && preco > 0;
        }
        public static bool ValidarPreco(double preco, out double precoValidado)
        {
            precoValidado = preco;
            return preco > 0;
        }
        public static bool ValidarQuantidade(string? input, out int quantidade)
        {
            return int.TryParse(input, out quantidade) && quantidade >= 0;
        }
        public static bool ValidarQuantidade(int quantidade, out int quantidadeValidada)
        {
            quantidadeValidada = quantidade;
            return quantidade > 0;
        }
    }
}