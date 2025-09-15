using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; }

        public BusinessAccount(string number, string name, double balance, double loanLimit) : base(number, name, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
