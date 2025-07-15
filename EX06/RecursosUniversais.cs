using System;

namespace RecursosUniversais
{
    public static class UniversalResources
    {
        public static string? ExibirRequisição(string requisicao)
        {
            Console.Write(requisicao);
            return Console.ReadLine();
        }
    }
}