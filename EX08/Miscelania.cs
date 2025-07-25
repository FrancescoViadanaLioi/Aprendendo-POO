﻿using System;
using System.Globalization;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirMensagemEncerrarPrograma(string msg)
        {
            Console.WriteLine(msg);
            PressAnyKey();
        }
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
    public static class Formatador
    {
        public static string? Formatar(double numero)
        {
            return numero.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
