using System;
using Domain;

namespace DependencyInjectionAndInversion
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        private readonly IPaymentConnection _paymentConnection;

        public CreditCardPaymentProcessor(IPaymentConnection paymentConnection)
        {
            _paymentConnection = paymentConnection;
        }

        public void ProcessPayment(Subscription subscription)
        {
            _paymentConnection.MakeCreditCardPayment(subscription.CreditCardNumber, subscription.InitialFee);
        }
    }
}