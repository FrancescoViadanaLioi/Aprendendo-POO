using System;
using ProdutoInfo;
using ProdutoInput;
using Miscelania;
class Program
{
    static void Main(string[] args)
    {
        string? nome = Entrada.InserirNome();
        double preco = Entrada.InserirPreco();
        int quantidade = Entrada.InserirQuantidade();

        Produto p = new Produto(nome, preco, quantidade);

        Console.WriteLine($"O produto {p.Nome} custa R${Formatador.Formatar(p.Preco)} e tem {p.Quantidade} unidades.");
        ConsoleUI.ExibirMensagem("Fim do programa.");
    }
}