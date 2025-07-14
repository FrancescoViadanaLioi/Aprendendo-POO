using System;
using Triangulo;
using Validacoes;
using Miscelania;

namespace TrianguloInput
{
    public static class LadosTriangulo
    {
        public static double LerLado(string lado)
        {
            while (true)
            {
                string? input = ExibirRequisicao($"Insira o lado {lado} do triângulo: ");
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.ExibirErroELimpar("ERRO! O valor não pode ser vazio.");
                    continue;
                }
                bool sucesso = Validations.ValidarLado(input);
                if (sucesso) return double.Parse(input);
                ConsoleUI.ExibirErroELimpar("ERRO! Verifique se o valor é um número real positivo.");
            }
        }
        private static string? ExibirRequisicao(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}