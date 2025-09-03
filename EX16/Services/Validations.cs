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
            return input != null && Regex.IsMatch(input, @"^[\p{L}]+(?:[ '-][\p{L}]+)*$");
        }
        public static bool ValidateLevel(string input, out WorkerLevel level)
        {
            return Enum.TryParse(input, ignoreCase: true, out level) && Enum.IsDefined(typeof(WorkerLevel), level);
        }
        public static bool ValidateSalary(string input, out double salary)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out salary) && salary > 0;
        }
        public static bool ValidateSalary(double salary)
        {
            return salary > 0;
        }
        public static bool ValidateDepartment(string input, out AvailableDepartments department)
        {
            return Enum.TryParse(input, ignoreCase: true, out department) && Enum.IsDefined(typeof(AvailableDepartments), department);
        }
    }
}
