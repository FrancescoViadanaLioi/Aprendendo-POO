using System;
using Triangulo;
using Validacoes;
using Miscelania;

namespace TrianguloInput
{
    public class LadosTriangulo
    {
        public double LerLado(string lado)
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
        private string? ExibirRequisicao(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}