using System;

namespace Miscelania
{
    public class MainMenu
    {
        public static void ExibirMenu()
        {
            ExibirTracinhos();
            Console.Write("MENU PRINCIPAL");
            ExibirTracinhos();
        }

        private static void ExibirTracinhos()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("-");
            }
        }
    }

    public static class ConsoleUI
    {
        public static void ExibirErroLimpar(string msgErro)
        {
            Console.WriteLine(msgErro);
            AguardarEntrada();
            Console.Clear();
        }
        public static void PausarComMensagem(string msgPausa)
        {
            Console.WriteLine(msgPausa);
            AguardarEntrada();
        }
        private static void AguardarEntrada()
        {
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey(true);
        }
    }
}