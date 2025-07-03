using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Triangulo;
using Miscelania;

namespace Entrada
{
    public class InserirDados
    {
        public static TrianguloModel LadosTriangulo()
        {
            while (true)
            {

                var t = new TrianguloModel();
                t.A = LerEntrada("A");
                t.B = LerEntrada("B");
                t.C = LerEntrada("C");

                if (t.EhValido())
                {

                    return t;
                }

                else
                {
                    Limpar.LimparTela("Os valores inseridos não respeitam as leis de formação do triângulo.");
                }
            }
        }

        private static double LerEntrada(string nomeLado)
        {
            double valor;
            while (true)
            {
                Console.Write($"Digite o valor do lado {nomeLado}: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, CultureInfo.InvariantCulture, out valor) && valor > 0) return valor;
                Limpar.LimparTela("Valor Inválido, tente de novo.");
            }
        }
    }
}