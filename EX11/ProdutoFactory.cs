using System;
using System.Globalization;
using Product;
using Validations;

namespace Product
{
    public class ProdutoFactory
    {
        public Produto CriarProduto(string nome, double preco)
        {
            if (!ValidacoesDeDados.ValidarNome(nome)) throw new ArgumentNullException("O nome é inválido.");
            if (!ValidacoesDeDados.ValidarPreco(preco, out double precoValidado )) throw new ArgumentNullException("O preco é inválido.");

            return new Produto(nome, precoValidado);
        }
    }
}