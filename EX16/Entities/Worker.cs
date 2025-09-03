﻿using System;
using System.Collections.Generic;
using EX16.Entities.EntitiesEnum;
using EX16.Services;

namespace EX16.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public Department Department { get; private set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
