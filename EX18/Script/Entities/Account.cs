using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18.Entities
{
    internal class Account
    {
        public string Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(string number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= (amount + 5.00);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
