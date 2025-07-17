using System;

namespace Funcionario
{
    public class AtributosFuncionario
    {
        public string? Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido(double salarioBruto, double imposto)
        {
            return salarioBruto - imposto;
        }
        public double AjusteDeSalario (double salarioBruto, int porcentagem, double imposto)
        {
            double salarioNovo = salarioBruto + salarioBruto * porcentagem / 100;
            return salarioNovo - imposto;
        }
    }
}