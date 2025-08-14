using Miscelania;
using UniversalResources;
using Validacoes;

namespace Vetor.Input
{
    public static class EntradaDoUsuario
    {
        public static int PedirTamanhoVetor()
        {
            while (true)
            {
                string? input = Requisicao.PedirEntrada("Qual é o tamanho do vetor? ");
                if (ValidacoesDeDados.ValidarTamanhoVetor(input!, out int tamanho)) return tamanho;
                ConsoleUI.ExibirErro("Verifique se o tamanho inserido é um valor positivo maior do que zero.");
            }
        }
        public static double[] PedirValores(int n)
        {
            double[] vector = new double[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    string? input = Requisicao.PedirEntrada($"Digite a altura da pessoa {i+1}: ");
                    if (ValidacoesDeDados.ValidarAltura(input!))
                    {
                        vector[i] = double.Parse(input!);
                        break;
                    }
                    ConsoleUI.ExibirErro("Verifique se a altura da pessoa é um número maior que 1.20 e menor que 2.40.");
                }
            }
            return vector;
        }
    }
}