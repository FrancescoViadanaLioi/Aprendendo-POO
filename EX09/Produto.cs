using System;

namespace ProdutoInfo
{
    public class Produto
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string? nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public static int AlterarEstoque(int quantidade, int variacao)
        {
            return quantidade + variacao;
        }
    }
}