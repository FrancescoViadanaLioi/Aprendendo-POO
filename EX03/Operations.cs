using System;
using System.Globalization;
using Pessoas;

namespace Operations
{
    public class CalculoDeMedia
    {
        public static double MediaAlturas(Pessoa p1, Pessoa p2)
        {
            return (p1.Altura + p2.Altura) / 2;
        }
    }
    public class Comparacao
    {
        public static Pessoa? CompararAlturas(Pessoa p1, Pessoa p2)
        {
            if (p1.Altura > p2.Altura) return p1;
            if (p2.Altura > p1.Altura) return p2;
            return null;
        }
    }
}