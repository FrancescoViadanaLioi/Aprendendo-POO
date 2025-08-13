using System;
using Miscelania;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void Exibir(Mensagem mensagem)
        {
            var CorOriginal = Console.ForegroundColor;
            Console.ForegroundColor = Colorir(mensagem.Tipo);
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}!";
            Console.WriteLine($"{prefixo} {mensagem.Conteudo}");

            Console.ForegroundColor = CorOriginal;

            if (mensagem.EsperarTecla)
            {
                Console.WriteLine("(Pressione qualquer tecla para continuar)");
                Console.ReadKey();
            }
            if (mensagem.LimparConsole)
            {
                Console.Clear();
            }
        }
        private static ConsoleColor Colorir(TipoMensagem tipo)
        {
            return tipo switch
            {
                TipoMensagem.Alerta => ConsoleColor.Yellow,
                TipoMensagem.Erro => ConsoleColor.Red,
                TipoMensagem.Informacao => ConsoleColor.Blue,
                TipoMensagem.Sucesso => ConsoleColor.Green,
                _ => ConsoleColor.White
            };
        }
    }
}