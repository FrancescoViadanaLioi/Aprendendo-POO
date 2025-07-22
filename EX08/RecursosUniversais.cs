using System;

namespace RecursosUniversais
{
    public static class Requisicoes
    {
        public static string? ExibirRequisicao(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }
    }
}