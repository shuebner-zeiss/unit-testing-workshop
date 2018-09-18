using System;
using Domain;

namespace StartingPoint
{
    public class PaymentProcessor
    {
        public void ProcessPayment(Subscription subscription)
        {
            var bankConnection = new BankConnection();
            bankConnection.MakeCreditCardPayment(subscription.CreditCardNumber, subscription.InitialFee);
        }
    }
}