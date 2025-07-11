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
}