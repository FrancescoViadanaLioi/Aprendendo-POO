using System;
using UniversalResources;
using Miscelania;
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
        public static int[] PedirValores(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    string? input = Requisicao.PedirEntrada($"Qual o valor do elemento {i}: ");
                    if (ValidacoesDeDados.ValidarElemento(input!))
                    {
                        vector[i] = int.Parse(input!);
                        break;
                    }
                    ConsoleUI.ExibirErro("Verifique se o elemento do vetor é um número inteiro.");
                }
            }
            return vector;
        }
    }
}