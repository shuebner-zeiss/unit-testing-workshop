using System;
using Domain;

namespace DependencyInversion
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Subscription subscription)
        {
            IPaymentConnection paymentConnection = ServiceLocator.GetPaymentConnection();
            paymentConnection.MakeCreditCardPayment(subscription.CreditCardNumber, subscription.InitialFee);
        }
    }
}