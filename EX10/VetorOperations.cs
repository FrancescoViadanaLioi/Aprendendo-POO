using System;

namespace Vetor.Operations
{
    public static class OperacoesVetor
    {
        public static double CalcularMedia(double[] vector , int n)
        {
            double somaDosElementos = 0;

            foreach (double elemento in vector)
            {
                somaDosElementos += elemento;
            }
            return somaDosElementos / n;
        }
    }
}