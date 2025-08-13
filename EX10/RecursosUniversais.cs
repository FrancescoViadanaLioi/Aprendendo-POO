using System;

namespace UniversalResources
{
    public static class Requisicao
    {
        public static string? PedirEntrada(string requisicao)
        {
            Console.Write(requisicao);
            return Console.ReadLine()!;
        }
    }
}