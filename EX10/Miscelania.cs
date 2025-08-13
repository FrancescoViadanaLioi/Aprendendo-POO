using System;
using Miscelania;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirAlerta(string conteudo)
            => Exibir(MensagemFactory.Alerta(conteudo));
        public static void ExibirErro(string conteudo)
            => Exibir(MensagemFactory.Erro(conteudo));
        public static void ExibirInformacao(string conteudo)
            => Exibir(MensagemFactory.Informacao(conteudo));
        public static void ExibirSucesso(string conteudo)
            => Exibir(MensagemFactory.Sucesso(conteudo));

        private static void Exibir(Mensagem mensagem)
        {
            var corOriginal = Console.ForegroundColor;
            Console.ForegroundColor = Colorir(mensagem.Tipo);
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}!";
            Console.WriteLine($"{prefixo} {mensagem.Conteudo}");

            Console.ForegroundColor = corOriginal;

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