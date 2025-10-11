using System;
using EX23.Entites;
using EX23.Services.Interfaces;

namespace EX23.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double uptadatedQutoa = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = uptadatedQutoa + _onlinePaymentService.PaymentFee(uptadatedQutoa);
                contract.AddInstallment(new Installment(date, uptadatedQutoa));
            }
        }
    }
}