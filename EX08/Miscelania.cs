using System;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErroELimpar(string msgErro)
        {
            Console.WriteLine($"ERRO! {msgErro}");
            PressAnyKey();
            Console.Clear();
        }
        private static string? PressAnyKey()
        {
            Console.WriteLine("(Pressione qualquer tecla para contiunar)");
            return Console.ReadLine();
        }
    }
}
