using System;
using Funcionario;
using FuncionarioInput;
using Miscelania;

class Program
{
    static void Main(string[] args)
    {
        var funcionario = new AtributosFuncionario();
        funcionario.Nome = EntradaFuncionario.PedirNome();
        funcionario.SalarioBruto = EntradaFuncionario.PedirSalario();
        funcionario.Imposto = EntradaFuncionario.PedirImposto();
        double salarioLiquido = funcionario.SalarioLiquido(funcionario.SalarioBruto, funcionario.Imposto);

        Console.Write($"{funcionario.Nome} recebe R${Formatador.FormatarCasaDecimal(funcionario.SalarioBruto)} brutos ao mês e ");
        Console.WriteLine($"o imposto de R${Formatador.FormatarCasaDecimal(funcionario.Imposto)} o faz receber R${Formatador.FormatarCasaDecimal(salarioLiquido)} líquidos.");
        ConsoleUI.MensagemExibir("Primeira parte concluída, vamos para a segunda.");

        int ajuste = AjusteSalarial.AjustarSalario();
        salarioLiquido = funcionario.AjusteDeSalario(funcionario.SalarioBruto, ajuste, funcionario.Imposto);

        Console.WriteLine($"Com o ajuste salarial, {funcionario.Nome} passa a receber R${Formatador.FormatarCasaDecimal(salarioLiquido)} líquidos.");
        ConsoleUI.MensagemExibir("Fim do programa.");
    }
}