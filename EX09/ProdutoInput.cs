using System;
using ProdutoInfo;
using Validations;
using Miscelania;
using UniversalResources;

namespace ProdutoInput
{
    public static class Entrada
    {
        public static string? InserirNome()
        {
            while (true)
            {
                string? input = RecursosUniversais.ExibirRequisicao("Insira o nome do produto: ");
                if (Validacoes.ValidarNome(input)) return input;
                ConsoleUI.ExibirErro("O nome é inválido. Verifique se há somente letras.");
            }
        }
        public static double InserirPreco()
        {
            while (true)
            {
                string? input = RecursosUniversais.ExibirRequisicao("Insira o preço do produto: R$");
                if (Validacoes.ValidarPreco(input, out double preco)) return preco;
                ConsoleUI.ExibirErro("Verifique se o valor é válido, ou seja, um número real positivo.");
            }
        }
        public static int InserirQuantidade()
        {
            while (true)
            {
                string? input = RecursosUniversais.ExibirRequisicao("Insira a quantidade inicial do estoque: ");
                if (Validacoes.ValidarQuantidade(input, out int quantidade)) return quantidade;
                ConsoleUI.ExibirErro("Verifique se a quantidade é maior ou igual a zero.");
            }
        }
    }
}