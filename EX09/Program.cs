using System;
using ProdutoInfo;
using ProdutoInput;
using Miscelania;
class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto("TV", 500.00, 20);

        p.Preco = 1500.00;

        Console.WriteLine($"O preço do produto {p.Nome} foi para R${Formatador.Formatar(p.Preco)}.");
    }
}