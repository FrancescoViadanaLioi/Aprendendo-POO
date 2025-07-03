using System;
using System.Globalization;
using Entrada;
using Saida;
using Miscelania;

class Program
{
    static void Main(string[] args)
    {
        var trianguloX = InserirDados.LadosTriangulo("X");
        Exibir.InfoTriangulo(trianguloX);

        Continuidade.PausarEProsseguir("Prosseguir com a exibição do outro triângulo");

        var trianguloY = InserirDados.LadosTriangulo("Y");
        Exibir.InfoTriangulo(trianguloY);
        Continuidade.PausarEProsseguir("Encerrar o programa");
    }
}