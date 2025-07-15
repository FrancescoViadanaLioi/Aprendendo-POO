using System;
using System.Globalization;
using RecursosUniversais;
using Validacoes;
using Miscelania;

namespace RetanguloInput
{
    public static class EntradaRetangulo
    {
        public static double LerEntrada(string item)
        {
            while (true)
            {
                string? input = UniversalResources.ExibirRequisição($"Insira o valor da {item} do retângulo: ");
                bool ehValido = Validations.MedidaEhValida(input);
                if (ehValido) return double.Parse(input!, CultureInfo.InvariantCulture);
                else ConsoleUI.ExibirErro($"ERRO! Verifique se a entrada é um número real positivo.");
            }
        }
    }
}