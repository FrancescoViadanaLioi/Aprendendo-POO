using System;
using System.Collections.Generic;
using EX16.Services;
using EX16.Entities.EntitiesEnum;
using EX16.View.Resources;
using EX16.Entities;

namespace EX16.View
{
    internal static class UserInput
    {
        public static AvailableDepartments EnterWithDepartment()
        {
            while (true)
            {
                string? input = DataInput.AskForInput("Type the department of the worker: ");
                if (input != null && Validations.ValidateDepartment(input, out AvailableDepartments departmentType)) return departmentType;
                ConsoleUI.ShowError("Check if you put an available department.");
            }
        }
        public static string EnterWithName()
        {
            while (true)
            {
                string? input = DataInput.AskForInput("Type the name of the worker: ");
                if (input != null && Validations.ValidateName(input)) return input;
                ConsoleUI.ShowError("Check if the name only has letters.");
            }
        }
        public static WorkerLevel EnterWithLevel()
        {
            while (true)
            {
                string? input = DataInput.AskForInput("Type the level of the worker: ");
                if (input != null && Validations.ValidateLevel(input, out WorkerLevel level)) return level;
                ConsoleUI.ShowError("Check if the level is available in our options.");
            }
        }
        public static double EnterWithDoubleNumber(string text)
        {
            while (true)
            {
                string? input = DataInput.AskForInput(text);
                if (input != null && Validations.ValidateDoubleInput(input, out double baseSalary)) return baseSalary;
                ConsoleUI.ShowError("Check if the base salary is more than 0 and also a number.");
            }
        }
        public static int EnterWithIntNumber(string text)
        {
            while (true)
            {
                string? input = DataInput.AskForInput(text);
                if (input != null && Validations.ValidateIntegerInput(input, out int contracts)) return contracts;
                ConsoleUI.ShowError("Verify if you put a number bigger than 0.");
            }
        }
        public static DateTime EnterWithDate()
        {
            while (true)
            {
                string? input = DataInput.AskForInput("Type the date of the contract (dd/MM/yyyy format): ");
                if (DateTime.TryParse(input, out DateTime date)) return date;
                ConsoleUI.ShowError("Verify if the date is valid.");
            }
        }
        public static string EnterWithMonthAndYear()
        {
            while (true)
            {
                string? input = DataInput.AskForInput("Type the month and year to calculate income (MM/YYYY): ");
                if (input != null && Validations.ValidateMonthYear(input, out string formattedDate)) return formattedDate;
                ConsoleUI.ShowError("The date only can accept in the right format and existent months and years.");
            }
        }
    }
}
