using System;
using System.Globalization;
using Entrada;
using Saida;
using Miscelania;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dados do triângulo X: ");
        var trianguloX = InserirDados.LadosTriangulo();
        Exibir.InfoTriangulo(trianguloX);

        Continuidade.PausarEProsseguir("Prosseguir com a exibição do outro triângulo");

        Console.WriteLine("Dados do triângulo Y: ");
        var trianguloY = InserirDados.LadosTriangulo();
        Exibir.InfoTriangulo(trianguloY);
        Continuidade.PausarEProsseguir("Encerrar o programa");
    }
}