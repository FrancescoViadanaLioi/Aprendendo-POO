using System;
using Validations;

namespace ProdutoInfo
{
    public class Produto
    {
        private string? _nome;
        private double _preco;
        private int _quantidade;

        public Produto() { }
        public Produto(string? nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string? Nome
        {
            get => _nome;
            set
            {
                if (Validacoes.ValidarNome(value))
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get => _preco;
            set
            {
                if (Validacoes.ValidarPreco(value, out double valorValidado))
                {
                    _preco = valorValidado;
                }
            }
        }
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                if (Validacoes.ValidarQuantidade(value, out int valorValidado))
                {
                    _quantidade = valorValidado;
                }
            }
        }
        public void AlterarEstoque(int variacao)
        {
            _quantidade += variacao;
        }
        public double ValorTotal()
        {
            return _quantidade * _preco;
        }
    }
}