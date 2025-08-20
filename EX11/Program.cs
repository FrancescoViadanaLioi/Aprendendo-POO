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
            string? nome = EntradaDoUsuario.EntrarComNome(n + 1);
            double preco = EntradaDoUsuario.EntrarComPreco(n + 1);
            produtos[n] = new Produto { Nome = nome, Preco = preco };
        }
    }
}