using System;
using Entrada;
using Operations;

namespace Saida
{
    public static class Exibicao
    {
        public static void ExibirDados()
        {
            string nomeUm = PessoaInput.InserirNome(1);
            int idadeUm = PessoaInput.InserirIdade(1);
            Pessoa pessoaUm = new Pessoa { Nome = nomeUm, Idade = idadeUm };

            string nomeDois = PessoaInput.InserirNome(2);
            int idadeDois = PessoaInput.InserirIdade(2);
            Pessoa pessoaDois = new Pessoa { Nome = nomeDois, Idade = idadeDois };

            Pessoa maisVelha = VerificacaoDeIdade.MaiorIdade(pessoaUm, pessoaDois);

            if (pessoaUm.Idade == pessoaDois.Idade)
            {
                Console.WriteLine($"Tanto {pessoaUm.Nome} quanto {pessoaDois.Nome} possuem a mesma idade.");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {maisVelha.Nome}, com {maisVelha.Idade} anos.");
            }
        }
    }
}