using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using EX16.Entities.EntitiesEnum;
using EX16.Entities;

namespace EX16.Services
{
    internal static class Validations
    {
        public static bool ValidateName(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[\p{L}]+(?:[ '-][\p{L}]+)*$");
        }
        public static bool ValidateLevel(string input, out WorkerLevel level)
        {
            return Enum.TryParse(input, ignoreCase: true, out level) && Enum.IsDefined(typeof(WorkerLevel), level);
        }
        public static bool ValidateDoubleInput(string input, out double num)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out num) && num > 0;
        }
        public static bool ValidateBaseSalary(double salary)
        {
            return salary > 0;
        }
        public static bool ValidateDepartment(string input, out AvailableDepartments department)
        {
            return Enum.TryParse(input, ignoreCase: true, out department) && Enum.IsDefined(typeof(AvailableDepartments), department);
        }
        public static bool ValidateIntegerInput(string input, out int num)
        {
            return int.TryParse(input, out num) && num > 0;
        }
        public static bool ValidateMonthYear(string input, out string formatted)
        {
            formatted = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^(0[1-9]|1[0-2])/([0-9]{4})$"))
                return false;

            int year = int.Parse(input.Substring(3, 4));

            if (year < 1 || year > DateTime.Now.Year)
                return false;

            formatted = input;
            return true;
        }


    }
}
