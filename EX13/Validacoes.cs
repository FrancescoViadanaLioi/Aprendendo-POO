using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Validations
{
    public static class Validacoes
    {
        public static bool ValidarNome(string nome)
        {
            nome = nome.Trim();
            string padrao = @"^[A-Za-zÀ-ÖØ-öø-ÿ'-]+$";
            return !string.IsNullOrWhiteSpace(nome) && Regex.IsMatch(nome, padrao);
        }
        public static bool ValidarID(string id)
        {
            id = id.Trim();
            string padraoId = @"^\d{3}$";
            return !string.IsNullOrWhiteSpace(id) && Regex.IsMatch(id, padraoId);
        }
        public static bool ValidarSalario(string salario, out double salarioValidado)
        {
            return double.TryParse(salario, CultureInfo.InvariantCulture, out salarioValidado) && salarioValidado > 1500;
        }
    }
}