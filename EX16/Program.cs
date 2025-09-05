using System;
using System.Transactions;
using EX16.Entities;
using EX16.Entities.EntitiesEnum;
using EX16.View;
using EX16.View.Resources;

class Program
{
    static void Main(string[] args)
    {
        AvailableDepartments deptName = UserInput.EnterWithDepartment();
        Console.WriteLine("Enter worker data:");
        string name = UserInput.EnterWithName();
        WorkerLevel workerLevel = UserInput.EnterWithLevel();
        double baseSalary = UserInput.EnterWithDoubleNumber("Type the base salary of the worker: $");

        Department dept = new Department(deptName);

        Worker worker = new Worker(name, workerLevel, baseSalary, dept);

        int numberOfContracts = UserInput.EnterWithIntNumber("How many contracts does the worker has? ");

        for (int i = 1; i <= numberOfContracts; i++)
        {
            Console.WriteLine($"Enter contract#{i} data:");
            DateTime date = UserInput.EnterWithDate();
            double valuePerHour = UserInput.EnterWithDoubleNumber("Enter with the salary per hour: $");
            int hours = UserInput.EnterWithIntNumber("Enter with the duration in hours: ");
            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
            Console.WriteLine();
        }
        string monthAndYear = UserInput.EnterWithMonthAndYear();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Department: {worker.Department.Name}");
        Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
        ConsoleUI.ShowInfo("End of program.");
    }
}