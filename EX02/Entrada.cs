using System;
using System.Text.RegularExpressions;
using Miscelania;

namespace Entrada
{
    public static class Pessoas
    {
        public static string InserirNome(int numPessoa)
        {
            while (true)
            {
                Console.Write($"Digite o nome da pessoa {numPessoa}: ");
                string? inputOriginal = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputOriginal)) continue;

                inputOriginal = inputOriginal.Trim();

                if (Regex.IsMatch(inputOriginal, @"^[\p{L}\s]{2,}$")) return inputOriginal;

                Limpar.LimparTela("Entrada inválida, verifique se o que foi inserido não haja números e nenhum caracter especial.");
            }
        }
    }
}