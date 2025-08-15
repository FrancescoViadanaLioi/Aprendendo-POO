using System;
using UniversalResources;
using Miscelania;
using Validations;

namespace Product.Input
{
    public static class EntradaDoUsuario
    {
        public static int EntrarComQuantidadeDeProdutos()
        {
            while (true)
            {
                string? input = RequisicoesDeDados.EntrarComInput("Quantos produtos serão analisados? ");
                if (ValidacoesDeDados.ValidarQuantidade(input!, out int quantidadeValidada)) return quantidadeValidada;
                ConsoleUI.ExibirErro("Verifique se a quantidade é um número inteiro maior que zero.");
            }
        }
        public static string? EntrarComNome(int n)
        {
            while (true)
            {
                string? input = RequisicoesDeDados.EntrarComInput($"Qual o nome do produto {n}? ");
                if (ValidacoesDeDados.ValidarNome(input!)) return input;
                ConsoleUI.ExibirErro("Verifique se o nome digitado possui mais de um caracter e não tenha números.");
            }
        }
        public static double EntrarComPreco(int n)
        {
            while (true)
            {
                string? input = RequisicoesDeDados.EntrarComInput($"Qual o preço do produto {n}? ");
                if (ValidacoesDeDados.ValidarPreco(input!, out double precoValidado)) return precoValidado;
                ConsoleUI.ExibirErro("Verifique se o preço é um número inteiro/decimal maior que zero.");
            }
        }
    }
}