using System;
using System.Collections.Generic;
using System.Globalization;

namespace EX16.View.Resources
{
    internal static class UniversalResources
    {
        public static string? AskForInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
    internal static class Formatter
    {
        public static string Format(double value)
        {
            return value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
