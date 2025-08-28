using System;
using Validations;

namespace Employee
{
    public class Funcionario
    {
        public string? Nome { get; private set; }
        public string? ID { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, string id, double salario)
        {
            Nome = DefinirNome(nome);
            ID = DefinirID(id);
            Salario = DefinirSalario(salario);
        }
        
        public void AlterarSalario(double pct)
        {
           Salario += Salario * (pct / 100);
        }

        private string DefinirNome(string nome)
        {
            if (!Validacoes.ValidarNome(nome)) throw new ArgumentException("O nome é inválido.");
            return nome;
        }
        private string DefinirID(string id)
        {
            if (!Validacoes.ValidarID(id)) throw new ArgumentException("Esse ID é inválido.");
            return id;
        }
        private double DefinirSalario(double salario)
        {
            if (salario < 1500) throw new ArgumentException("Esse salário é inválido.");
            return salario;
        }
    }
}