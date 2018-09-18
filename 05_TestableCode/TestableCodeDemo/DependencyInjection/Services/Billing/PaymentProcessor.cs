using System;
using Domain;

namespace DependencyInjection
{
    public class PaymentProcessor
    {
        private readonly BankConnection _bankConnection;

        public PaymentProcessor(BankConnection bankConnection)
        {
            _bankConnection = bankConnection;
        }

        public void ProcessPayment(Subscription subscription)
        {
            _bankConnection.MakeCreditCardPayment(subscription.CreditCardNumber, subscription.InitialFee);
        }
    }
}