﻿using System;

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
    public static class Continuar
    {
        public static void TeclarEContinuar(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}