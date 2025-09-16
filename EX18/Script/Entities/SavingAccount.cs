using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EX18.Entities
{
    internal class SavingAccount: Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(string number, string name, double balance, double interestRate) : base(number, name, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
