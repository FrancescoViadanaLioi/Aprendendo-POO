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
        public double AjusteDeSalario(double salarioBruto, double porcentagem)
        {
            return salarioBruto + salarioBruto * (porcentagem / 100);
        }
    }
}