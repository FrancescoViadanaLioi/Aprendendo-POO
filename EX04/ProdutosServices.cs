using System;
using Validacoes;
using Miscelania;

namespace ProdutosServices
{
    public class CalculosComProdutos
    {
        public static double CalcularValorTotalEstocado(double preco, int qntd)
        {
            return preco * qntd;
        }
    }
    public class AjusteDeEstoque
    {
        public static int AumentarEstoque(int qntd, int valor)
        {
            while (true)
            {
                string? input = ExibirRequisicao("Quantas unidades foram adicionadas ao estoque?");
                bool result = Validations.QntdEhValida(input);
                if (result) return qntd + valor;
                ConsoleUI.ExibirErroLimpar("ERRO! somente números inteiros positivos são válidos.");
            }
        }
        public static int ReduzirEstoque(int qntd, int valor)
        {
            return qntd - valor;
        }
        private static string? ExibirRequisicao(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}