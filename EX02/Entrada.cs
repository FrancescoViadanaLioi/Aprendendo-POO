using System;
using System.Text.RegularExpressions;
using Miscelania;

namespace Entrada
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
    }

    public static class PessoaInput
    {
        public static string InserirNome(int numPessoa)
        {
            while (true)
            {
                Console.Write($"Digite o nome da pessoa {numPessoa}: ");
                string? inputOriginal = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(inputOriginal)) continue;

                if (Regex.IsMatch(inputOriginal, @"^[\p{L}\s]{2,}$")) return inputOriginal;

                Limpar.LimparTela("Entrada inválida, verifique se o que foi inserido não haja números e nenhum caracter especial.");
            }
        }
        public static int InserirIdade(int numPessoa)
        {
            while (true)
            {
                Console.Write($"Digite a idade da pessoa {numPessoa}: ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input)) continue;

                if (int.TryParse(input, out int idade) && (idade >= 0 && idade <= 120)) return idade;

                Limpar.LimparTela("Entrada inválida, verifique se você digitou um número inteiro maior ou igual a zero.");
            }
        }
    }
}