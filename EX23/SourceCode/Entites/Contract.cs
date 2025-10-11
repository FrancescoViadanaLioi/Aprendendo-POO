using System;
using System.Collections.Generic;
using EX23.Entites;

namespace EX23.Entites
{
    internal class Contract
    {
        public int ID { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int iD, DateTime date, double totalValue)
        {
            ID = iD;
            Date = date;
            TotalValue = totalValue;
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
