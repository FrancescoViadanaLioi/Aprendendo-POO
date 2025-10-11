using System;
using System.Runtime.CompilerServices;
using EX23.Services.Interfaces;

namespace EX23.Services
{
    internal class PaypalPaymentService: IOnlinePaymentService
    {
        private const double FeePercantage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double PaymentFee(double amount)
        {
            return amount * FeePercantage;
        }
        public double Interest(double amount, int months)
        {
            return amount * months * MonthlyInterest;
        }
    }
}
