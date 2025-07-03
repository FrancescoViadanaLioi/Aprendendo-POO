using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Triangulo;
using Miscelania;
using System.Security;

namespace Entrada
{
    public class InserirDados
    {
        public static TrianguloModel LadosTriangulo(string nomeTriangulo)
        {
            string titulo = $"Informações do triângulo {nomeTriangulo}";
            while (true)
            {
                Console.WriteLine(titulo);
                var t = new TrianguloModel();
                t.A = LerEntrada("A", titulo);
                t.B = LerEntrada("B", titulo);
                t.C = LerEntrada("C", titulo);

                if (t.EhValido()) return t;

                else
                {
                    Limpar.LimparTela("Os valores inseridos não respeitam as leis de formação do triângulo.");
                }
            }
        }

        private static double LerEntrada(string nomeLado, string titulo)
        {
            double valor;
            while (true)
            {
                Console.Write($"Digite o valor do lado {nomeLado}: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, CultureInfo.InvariantCulture, out valor) && valor > 0) return valor;
                Limpar.LimparTela("Valor Inválido, tente de novo.");
                Console.WriteLine(titulo);
            }
        }
    }
}