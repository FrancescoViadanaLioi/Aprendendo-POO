using System;

namespace Operations
{
    internal class Operacoes
    {
        public static int Sum(params int[] nums)
        {
            int soma = 0;
            foreach (int valor in nums)
            {
                soma += valor;
            }
            return soma;
        }
    }
}
