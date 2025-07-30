using System;

namespace UniversalResources
{
    public static class RecursosUniversais
    {
        public static string? ExibirRequisicao(string texto)
        {
            Console.WriteLine(texto);
            return Console.ReadLine();
        }
    }
}