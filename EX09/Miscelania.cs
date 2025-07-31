using System;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErro(string msgErro)
        {
            ExibirMensagem($"ERRO! {msgErro}");
            Console.Clear();
        }
        public static void ExibirMensagem(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
    public static class Formatador
    {
        public static string Formatar(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}