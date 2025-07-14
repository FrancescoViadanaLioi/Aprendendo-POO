using System;
using System.Text.RegularExpressions;
using System.Globalization;
using Produto;
using Validacoes;
using Miscelania;
using System.Runtime.CompilerServices;

namespace RegistrarProduto
{
    public class Registrador
    {
        public static string? RegistrarNome()
        {
            while (true)
            {
                string? input = ExibirRequisicao("Digite o nome do produto: ");
                bool ehValido = Validations.NomeEhValido(input);
                if (ehValido) return input!.Trim();
                ConsoleUI.ExibirErroLimpar("ERRO! Verifique se não há espaços em branco desnecessários e nenhum número.");
            }
        }
        public static double RegistrarPreco()
        {
            while (true)
            {
                string? input = ExibirRequisicao("Digite o preço do produto: ");
                bool ehValido = Validations.PrecoEhValido(input);
                if (ehValido) return double.Parse(input!);
                ConsoleUI.ExibirErroLimpar("ERRO! Verifique se você digitou somente um número positivo, sem letras ou símbolos.");
            }
        }
        public static int RegistrarQuantidadeInicial()
        {
            while (true)
            {
                string? input = ExibirRequisicao("Digite a quantidade inicial do produto em estoque: ");
                bool ehValido = Validations.QntdEhValida(input);
                if (ehValido) return int.Parse(input!);
                ConsoleUI.ExibirErroLimpar("ERRO! Verifique se foi digitando somente um número inteiro positivo.");
            }
        }
        private static string? ExibirRequisicao(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}