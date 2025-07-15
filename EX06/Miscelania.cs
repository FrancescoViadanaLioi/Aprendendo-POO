using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErro(string msgErro)
        {
            Console.WriteLine(msgErro);
            AnyKey();
            Console.Clear();
        }
        public static void PausarEContinuar(string msg)
        {
            Console.WriteLine(msg);
            AnyKey();
        }
        private static void AnyKey()
        {
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
    public static class Formatador
    {
        public static string FormatarDuasCasas(double numero)
        {
            return numero.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
