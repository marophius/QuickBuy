using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Entities.Enums;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class PaymentForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBankSlip {
            get { return Id == (int)PaymentFormMethod.BankSlip; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)PaymentFormMethod.CreditCard; }
        }
        public bool IsDeposit
        {
            get { return Id == (int)PaymentFormMethod.Deposit; }
        }
        public bool IsUndefined
        {
            get { return Id == (int)PaymentFormMethod.Undefined; }
        }
    }
}
