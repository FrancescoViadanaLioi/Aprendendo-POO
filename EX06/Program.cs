using System;
using Retangulo;
using RetanguloInput;
using Miscelania;

class Program
{
    static void Main(string[] args)
    {
        var retangulo = new Retangle();
        retangulo.Largura = EntradaRetangulo.LerEntrada("Largura");
        retangulo.Altura = EntradaRetangulo.LerEntrada("Altura");
        double perimetroRetangulo = Retangle.CalcularPerimetro(retangulo.Largura, retangulo.Altura);
        double diagonalRetangulo = Retangle.CalcularDiagonal(retangulo.Largura, retangulo.Altura);

        Console.WriteLine($"O retângulo, de medidas {retangulo.Largura}m e {retangulo.Altura}, seu perímetro é {Formatador.FormatarDuasCasas(perimetroRetangulo)}m, e sua diagonal mede {Formatador.FormatarDuasCasas(diagonalRetangulo)}m.");
        ConsoleUI.PausarEContinuar("Fim do programa.");
    }
}