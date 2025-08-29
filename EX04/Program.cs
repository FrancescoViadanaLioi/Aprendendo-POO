using System;
using System.Globalization;
using Produto;
using RegistrarProduto;
using ProdutosServices;
using Miscelania;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        var produto = new Product();
        produto.Nome = Registrador.RegistrarNome();
        produto.Preco = Registrador.RegistrarPreco();
        produto.Qntd = Registrador.RegistrarQuantidadeInicial();
        double valorTotal = CalculosComProdutos.CalcularValorTotalEstocado(produto.Preco, produto.Qntd);

        Console.WriteLine($"O produto {produto.Nome}, custa R${produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, há {produto.Qntd} unidades, totalizando em valor: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        ConsoleUI.PausarComMensagem("Fim do programa.");
    }
}