using System;

namespace Miscelania
{
    public static class Limpeza
    {
        public static void LimparTela(string msgErro)
        {
            Console.WriteLine(msgErro);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static class Pausa
    {
        public static void Continuar(string msgMis)
        {
            Console.WriteLine(msgMis);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
        }
    }
}