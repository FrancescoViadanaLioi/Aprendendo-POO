using System;
using System.Globalization;

namespace Miscelania
{
    public enum TipoMensagem
    {
        Alerta,
        Erro,
        Informacao,
        Sucesso
    }
    public class Mensagem
    {
        public string Conteudo { get; }
        public TipoMensagem Tipo { get; }
        public bool EsperarTecla { get; }
        public bool LimparConsole { get; }

        public Mensagem(string conteudo, TipoMensagem tipo, bool esperarTecla, bool limparConsole)
        {
            Conteudo = conteudo ?? throw new ArgumentNullException(nameof(conteudo));
            Tipo = tipo;
            EsperarTecla = esperarTecla;
            LimparConsole = limparConsole;
        }
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