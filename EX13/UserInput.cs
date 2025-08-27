using System;
using Validations;
using Miscelania;
using UniversalResources;

namespace Employee.Input
{
    public static class EntradaDoUsuario
    {
        public static string EntrarComNome(int n)
        {
            while (true)
            {
                string? input = RequisicaoDeDados.PedirEntrada($"Digite o nome do funcionário {n}: ");
                if (input != null && Validacoes.ValidarNome(input)) return input;
                ConsoleUI.ExibirErro("Verifique se o nome tem somente letras, e se necessário, hífens ou apóstrofo.");
            }
        }
        public static string EntrarComID(int n)
        {
            while (true)
            {
                string? input = RequisicaoDeDados.PedirEntrada($"Digite o ID do funcionário {n}: ");
                if (input != null && Validacoes.ValidarID(input)) return input;
                ConsoleUI.ExibirErro("Verifique se o ID tem é composto por somente 3 números inteiros positivos.");
            }
        }
        public static double EntrarComSalario(int n)
        {
            while (true)
            {
                string? input = RequisicaoDeDados.PedirEntrada($"Digite o salário do funcionário {n}: R$");
                if (input != null && Validacoes.ValidarSalario(input, out double salarioValidado)) return salarioValidado;
                ConsoleUI.ExibirErro("Verifique se o salário é pelo menos um salário mínimo (R$1500) e se é um número válido.");
            }
        }
        public static int EntrarComNumeroValido()
        {
            while (true)
            {
                string? input = RequisicaoDeDados.PedirEntrada("Quantos funcionários serão analisados? ");
                if (input != null && Validacoes.ValidarNumeroDeFuncionarios(input, out int numeroValidado)) return numeroValidado;
                ConsoleUI.ExibirErro("Verifique se você digitou um número positivo inteiro.");
            }
        }
    }
}