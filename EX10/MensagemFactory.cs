using System;
using Miscelania;

namespace Miscelania
{
    public static class MensagemFactory
    {
        public static Mensagem Alerta(string conteudo, bool esperarTecla = true, bool limparConsole = false)
            => new Mensagem(conteudo, TipoMensagem.Alerta, esperarTecla, limparConsole);

        public static Mensagem Erro(string conteudo, bool esperarTecla = true, bool limparConsole = true)
            => new Mensagem(conteudo, TipoMensagem.Erro, esperarTecla, limparConsole);

        public static Mensagem Informacao(string conteudo, bool esperarTecla = true, bool limparConsole = false)
            => new Mensagem(conteudo, TipoMensagem.Informacao, esperarTecla, limparConsole);

        public static Mensagem Sucesso(string conteudo, bool esperarTecla = true, bool limparConsole = false)
            => new Mensagem(conteudo, TipoMensagem.Sucesso, esperarTecla, limparConsole);
    }
}