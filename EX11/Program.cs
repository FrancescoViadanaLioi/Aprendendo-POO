using System;
using Product;
using Product.Input;
using Miscelania;
using UniversalResources;

class Program
{
    static void Main(string[] args)
    {
        int n = EntradaDoUsuario.EntrarComQuantidadeDeProdutos();
        Produto[] produtos = new Produto[n];

        for (int i = 0; i < n; i++)
        {
            string? nome = EntradaDoUsuario.EntrarComNome(i + 1);
            double preco = EntradaDoUsuario.EntrarComPreco(i + 1);
            produtos[i] = new Produto { Nome = nome, Preco = preco };
        }
        double soma = 0;
        
        for (int i = 0; i < n; i++)
        {
            soma += produtos[i].Preco;
        }
        double media = Produto.CalcularMedia(soma, n);

        Console.WriteLine($"A média dos preços é de R${FormatadorDecimal.Formatar(media)}");
        ConsoleUI.ExibirInfo("Fim do programa.");
    }
}