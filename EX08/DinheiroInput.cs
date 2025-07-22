using System;
using Validations;
using RecursosUniversais;
using Miscelania;

namespace DinheiroInput
{
    public static class Entrada
    {
        public static double EntrarComPedido(string msg)
        {
            while (true)
            {
                string? input = Requisicoes.ExibirRequisicao(msg);
                bool sucesso = Validacoes.ValidarDecimal(input, out double valor);
                if (sucesso) return valor;
                ConsoleUI.ExibirErroELimpar("Verifique se o valor inserido é um número válido (número positivo decimal).");
            }
        }
    }
}