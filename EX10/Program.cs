using System;
using Miscelania;
using UniversalResources;
using Vetor.Input;
using Vetor.Operations;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = EntradaDoUsuario.PedirTamanhoVetor();
        ConsoleUI.ExibirSucesso("Tamanho registrado com sucesso!");

        double[] vetor = EntradaDoUsuario.PedirValores(tamanho);
        ConsoleUI.ExibirSucesso("Alturas registradas com sucesso!");

        ConsoleUI.ExibirAlerta("AS ALTURAS DAS PESSOAS SERÃO INSERIDOS ABAIXO:");
        Console.Clear();

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Altura {i+1}: {FormatadorDecimal.Formatar(vetor[i])}");
        }

        ConsoleUI.ExibirAlerta("Alturas exibidas, deseja prosseguir para a exibição da média?");
        Console.WriteLine();

        double mediaDasAlturas = OperacoesVetor.CalcularMedia(vetor, tamanho);
        Console.WriteLine($"A média das alturas é de {FormatadorDecimal.Formatar(mediaDasAlturas)}");
        ConsoleUI.ExibirInformacao("Fim do programa.");
    }
}