using Employee;
using Employee.Input;
using Miscelania;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UniversalResources;

class Program
{
    static void Main(string[] args)
    {
        int n = EntradaDoUsuario.EntrarComNumeroValido();
        List<Funcionario> lista = new List<Funcionario>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Funcionário #{i}");
            string nome = EntradaDoUsuario.EntrarComNome(i);
            string id = EntradaDoUsuario.EntrarComID(i);
            double salario = EntradaDoUsuario.EntrarComSalario(i);
            lista.Add(new Funcionario(nome, id, salario));
        }

        Funcionario emp = EntradaDoUsuario.LerIdDigitado(lista);

        if (emp != null)
        {
            double porcentagem = EntradaDoUsuario.EntrarComPorcentagem();
            emp.AlterarSalario(porcentagem);
        }
        else throw new ArgumentException("Como?");

        ConsoleUI.ExibirInfo("Segue abaixo a lista atualizada dos funcionários: ");

        foreach (Funcionario func in lista)
        {
            Console.WriteLine(func.Nome);
            Console.WriteLine(func.ID);
            Console.WriteLine($"R${FormatadorDecimal.Formatar(func.Salario)}");
        }
    }
}