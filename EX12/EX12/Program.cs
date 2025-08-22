using System;
using Operations;

class Program
{
    static void Main(string[] args)
    {
        int soma = Operacoes.Sum(1, 2, 3, 4, 5, 6, 7, 8);
        Console.WriteLine(soma);
    }
}