using System;
using System.Globalization;

namespace Validacoes
{
    public static class ValidacoesDeDados
    {
        public static bool ValidarTamanhoVetor(string input, out int tamanho)
        {
            return int.TryParse(input, out tamanho) && tamanho > 0;
        }
        public static bool ValidarAltura(string input)
        {
            return double.TryParse(input, out double altura) && (altura >= 1.20 && altura <= 2.40);
        }
    }
}