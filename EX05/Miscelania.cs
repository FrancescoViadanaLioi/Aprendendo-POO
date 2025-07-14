using System;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErroELimpar(string msgErro)
        {
            Console.WriteLine(msgErro);
            AguardarEntrada();
            Console.Clear();
        }
        public static void SairPausa(string msg)
        {
            Console.WriteLine(msg);
            AguardarEntrada();
        }
        private static void AguardarEntrada()
        {
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
}