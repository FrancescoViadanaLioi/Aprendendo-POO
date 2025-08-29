using System;
using Operations;

class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        Operacoes.TriplicarValor(a, out int novo);
        Console.WriteLine(novo);
    }
}