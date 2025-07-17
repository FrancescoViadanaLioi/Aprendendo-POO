using System;
using System.Globalization;
using Validacoes;
using RecursosUniversais;
using Miscelania;

namespace FuncionarioInput
{
    public static class EntradaFuncionario
    {
        public static string? PedirNome()
        {
            while (true)
            {
                string? input = UniversalResources.ExibirRequisicao("Digite o nome do funcionário: ");
                bool sucesso = Validations.NomeEhValido(input, out string? nome);
                if (sucesso) return nome;
                ConsoleUI.ExibirErro("ERRO! Verifique se há somente letras e não há apenas um espaço em branco.");
            }
        }
        public static double PedirSalario()
        {
            while (true)
            {
                string? input = UniversalResources.ExibirRequisicao("Digite o salário do funcionário: ");
                bool sucesso = Validations.SalarioEhValido(input, out double salario);
                if (sucesso) return salario;
                ConsoleUI.ExibirErro("ERRO! Verifique se o salário digitado é pelo menos de R$1500. Não deve conter nem letras e nem números negativos.");
            }
        }
        public static double PedirImposto()
        {
            while (true)
            {
                string? input = UniversalResources.ExibirRequisicao("Digite o imposto sobre aquele funcionário: ");
                bool sucesso = Validations.ImpostoEhValido(input, out double imposto);
                if (sucesso) return imposto;
                ConsoleUI.ExibirErro("ERRO! Verifique se o imposto sobre aquele funcionário é um valor válido (o imposto deve ser no mínimo de R$0.00)");
            }
        }
    }
}