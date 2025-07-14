using System;
using Validacoes;

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
            return qntd + valor;
        }
        public static int ReduzirEstoque(int qntd, int valor)
        {
            return qntd - valor;
        }
    }
}