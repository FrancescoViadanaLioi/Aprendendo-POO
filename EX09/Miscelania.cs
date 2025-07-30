using System;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErro(string msgErro)
        {
            ExibirMensagem(msgErro);
            Console.Clear();
        }
        public static void ExibirMensagem(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
}