using Product.Input;
using System;
using System.Transactions;
using Validations;

namespace Product
{

    public class Produto
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }

        public Produto() { }
        public Produto(string nome, double preco)
        {
            if (!ValidacoesDeDados.ValidarNome(nome)) throw new ArgumentException("O nome é inválido");
            if (!ValidacoesDeDados.ValidarPreco(preco, out double precoValidado)) throw new ArgumentException("O preço é inválido.");
            Nome = nome;
            Preco = precoValidado;
        }
        public static double CalcularMedia(double soma, int n)
        {
            return soma / n;
        }
    }
}