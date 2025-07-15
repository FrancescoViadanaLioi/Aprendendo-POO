using System;
using System.Globalization;

namespace Validacoes
{
    public static class Validations
    {
        public static bool MedidaEhValida(string? tamanho)
        {
            if (string.IsNullOrWhiteSpace(tamanho)) return false;
            bool sucesso = double.TryParse(tamanho, CultureInfo.InvariantCulture, out double numero);
            return sucesso && numero > 0;
        }
    }
}