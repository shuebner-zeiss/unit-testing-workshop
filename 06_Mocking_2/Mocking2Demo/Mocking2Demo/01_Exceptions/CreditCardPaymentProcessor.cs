using System;

namespace Mocking2Demo._01
{
    public class CreditCardPaymentProcessor
    {
        private readonly IPaymentConnection _paymentConnection;

        public CreditCardPaymentProcessor(IPaymentConnection paymentConnection)
        {
            _paymentConnection = paymentConnection;
        }

        public PaymentResult ProcessPayment(Subscription subscription)
        {
            return PaymentResult.Error;
        }

        public enum PaymentResult
        {
            Error,
            Success,
        }
    }
}
