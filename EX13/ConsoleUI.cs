using System;
using System.Runtime.CompilerServices;
using Miscelania;

namespace Miscelania
{
    public static class ConsoleUI
    {
        public static void ExibirErro(string conteudo)
        {
            var msg = new Mensagem(conteudo, TipoMensagem.Erro, esperarTecla: true, limparConsole: true);
            ExibirMensagem(msg);
        }
        public static void ExibirInfo(string conteudo)
        {
            var msg = new Mensagem(conteudo, TipoMensagem.Informacao, esperarTecla: true, limparConsole: false);
            ExibirMensagem(msg);
        }
        private static void ExibirMensagem(Mensagem mensagem)
        {
            string prefixo = $"{mensagem.Tipo.ToString().ToUpper()}:";
            Console.WriteLine($"{prefixo}: {mensagem.Conteudo}");

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
    }
}