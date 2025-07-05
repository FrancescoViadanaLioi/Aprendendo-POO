using System;
using Entrada;

namespace Operations
{
    public class VerificacaoDeIdade
    {
        public static Pessoa MaiorIdade(Pessoa p1, Pessoa p2)
        {
            return p1.Idade >= p2.Idade ? p1 : p2;
        }
    }
}