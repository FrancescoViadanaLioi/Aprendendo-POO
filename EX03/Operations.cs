using System;
using System.Globalization;
using Entrada;
using Pessoas;

namespace Operations
{
    public class Operations
    {
        public static double MediaAlturas(Pessoa p1, Pessoa p2)
        {
            return (p1.Altura + p2.Altura) / 2;
        }
    }
}