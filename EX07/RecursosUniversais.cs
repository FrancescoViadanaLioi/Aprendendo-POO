using System;

namespace RecursosUniversais
{
    public static class UniversalResources
    {
        public static string? ExibirRequisicao(string texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }
    }
}