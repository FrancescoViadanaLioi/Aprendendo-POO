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
            if (string.IsNullOrWhiteSpace(conteudo))
                throw new ArgumentNullException("O conteudo da mensagem não pode ser vazio.");

            Conteudo = conteudo ?? throw new ArgumentNullException(nameof(conteudo));
            Tipo = tipo;
            EsperarTecla = esperarTecla;
            LimparConsole = limparConsole;
        }
    }
}