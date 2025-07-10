using System;

namespace ProdutosServices
{
    public class CalculosComProdutos
    {
        public static double CalcularValorTotalEstocado(Produto.Produto preco, Produto.Produto unidades)
        {
            return preco.Preco * unidades.Qntd;
        }
    }
}