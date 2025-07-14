using System;
using System.Globalization;
using Miscelania;
using Triangulo;
using TrianguloInput;
using Validacoes;

class Program
{
    static void Main(string[] args)
    {
        var triangulo = new Triangle();

        triangulo.A = LadosTriangulo.LerLado("A");
        triangulo.B = LadosTriangulo.LerLado("B");
        triangulo.C = LadosTriangulo.LerLado("C");

        bool trianguloEhPossivel = Validations.ValidarTriangulo(triangulo.A, triangulo.B, triangulo.C);

        if (trianguloEhPossivel == false)
        {
            Console.WriteLine("Não é possível formar um triângulo com essas medidas.");
        }
        else
        {
            double areaTriangulo = Triangle.CalcularArea(triangulo.A, triangulo.B, triangulo.C);
            double perimetro = Triangle.CalcularPerimetro(triangulo.A, triangulo.B, triangulo.C);

            Console.WriteLine($"A área é: {areaTriangulo.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"O perímetro é de {perimetro.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
        ConsoleUI.SairPausa("Fim do Programa.");
    }
}