using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using EX19.Controllers;

namespace EX19.Services
{
    internal static class ProductValidations
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            foreach (char c in name)
            {
                if (!(char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-' || c == '\'')) return false;
            }
            return true;
        }
        public static bool IsValidPrice(string input)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out double price) && price > 0.00;
        }
        public static bool IsCustomFeeValid(string input)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out double fee) && (fee >= 0.00 && fee <= 100);
        }
        public static bool IsDateValid(string input)
        {
            return DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None , out DateTime formattedDate) && formattedDate > DateTime.MinValue;
        }
    }
}
