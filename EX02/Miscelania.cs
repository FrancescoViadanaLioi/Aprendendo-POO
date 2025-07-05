using System;

namespace Miscelania
{
    public static class Limpar
    {
        public static void LimparTela(string msgErro)
        {
            Console.WriteLine(msgErro);
            Console.WriteLine("(Pressione qualquer tecla para continuar)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}