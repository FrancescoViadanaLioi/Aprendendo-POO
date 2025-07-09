using System;
using System.Globalization;
using Entrada;
using Miscelania;
using Operations;
using Pessoas;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Pessoa();
        p1.Nome = PessoaInput.InserirNome("1");
        p1.Altura = PessoaInput.InserirAltura("1");

        var p2 = new Pessoa();
        p2.Nome = PessoaInput.InserirNome("2");
        p2.Altura = PessoaInput.InserirAltura("2");

        Pessoa? resultado = Comparacao.CompararAlturas(p1, p2);

        if (resultado != null)
        {
            Console.WriteLine($"A pessoa mais alta é {resultado.Nome!}, com {resultado.Altura.ToString(CultureInfo.InvariantCulture)}m de altura.");
        }
        else
        {
            Console.WriteLine("As alturas empatam.");
        }

        double media = CalculoDeMedia.MediaAlturas(p1, p2);

        Console.WriteLine($"A média das alturas é de {media.ToString("F2", CultureInfo.InvariantCulture)}m.");

        Pausa.Continuar("Fim do programa.");
    }
}