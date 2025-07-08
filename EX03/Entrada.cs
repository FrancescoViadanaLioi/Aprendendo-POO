using System;
using System.Text.RegularExpressions;
using System.Globalization;
using Pessoas;
using Miscelania;
using System.Diagnostics;

namespace Entrada
{
    public static class PessoaInput
    {
        public static string InserirNome(string numPessoa)
        {
            while (true)
            {
                Console.Write($"Digite o nome da Pessoa {numPessoa}: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Limpeza.LimparTela("Erro! Digite um nome válido (sem espaços em branco e/ou números).");
                    continue;
                }
                if (NomeEhValido(input)) return input;
                Limpeza.LimparTela("Erro! Veja se a entrada possui apenas letras.");
            }
        }
        public static double InserirAltura(string numPessoa)
        {
            while (true)
            {
                Console.Write($"Digite a altura da pessoa {numPessoa} em metros: ");
                string? input = Console.ReadLine();

                if (double.TryParse(input, CultureInfo.InvariantCulture, out double altura) && altura >= 0.50 && altura <= 2.70) return altura;
                Limpeza.LimparTela("Erro! Digite uma altura válida, entre 0.50 metros e 2.70 metros.");
            }
        }
        private static bool NomeEhValido(string input)
        {
            string trimmed = input.Trim();
            if (Regex.IsMatch(trimmed, @"\s{2,}")) return false;

            return Regex.IsMatch(trimmed, @"^[\p{L} ]+$");
        }
    }
}