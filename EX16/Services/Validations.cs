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
            return string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[\p{L}]+(?:[ '-][\p{L}]+)*$");
        }
        public static bool ValidateLevel(string input, out WorkerLevel level)
        {
            return Enum.TryParse(input, ignoreCase: true, out level) && Enum.IsDefined(typeof(WorkerLevel), level);
        }
        public static bool ValidateBaseSalary(string input, out double salary)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out salary) && salary > 0;
        }
        public static bool ValidateBaseSalary(double salary)
        {
            return salary > 0;
        }
        public static bool ValidateDepartment(string input, out AvailableDepartments department)
        {
            return Enum.TryParse(input, ignoreCase: true, out department) && Enum.IsDefined(typeof(AvailableDepartments), department);
        }
        public static bool ValidateContracts(string input, out int contracts)
        {
            return int.TryParse(input, out contracts) && contracts > 0;
        }
    }
}
