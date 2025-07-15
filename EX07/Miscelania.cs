using System;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErro(string msgErro)
        {
            MensagemExibir(msgErro);
            Console.Clear();
        }
        public static void MensagemExibir(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
    public static class Formatador
    {
        public static string? FormatarCasaDecimal(double valor)
        {
            return valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}