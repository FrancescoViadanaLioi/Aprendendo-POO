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
            if (string.IsNullOrWhiteSpace(input)) return false;

            if (!DateTime.TryParseExact(input, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date)) return false;

            if (date.Year < DateTime.MinValue.Year || date.Year > DateTime.Now.Year) return false;

            formatted = date.ToString("MM/yyyy");
            return true;
        }
    }
}
