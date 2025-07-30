using System;

namespace UniversalResources
{
    public static class RecursosUniversais
    {
        public static string? ExibirRequisicao(string texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }
    }
}