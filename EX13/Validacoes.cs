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
        public static bool ValidarNumeroDeFuncionarios(string input, out int numeroDeFuncionarios)
        {
            return int.TryParse(input, out numeroDeFuncionarios) && numeroDeFuncionarios > 0;
        }
        public static bool ValidarPorcentagem(string input, out double porcentagem)
        {
            return double.TryParse(input, out porcentagem) && porcentagem != 0;
        }
    }
}