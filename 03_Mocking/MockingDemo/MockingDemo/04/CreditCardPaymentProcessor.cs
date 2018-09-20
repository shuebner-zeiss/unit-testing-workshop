using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._04
{
    public class CreditCardPaymentProcessor
    {
        private readonly IPaymentConnection _paymentConnection;

        public CreditCardPaymentProcessor(IPaymentConnection paymentConnection)
        {
            _paymentConnection = paymentConnection;
        }

        public Result ProcessPayment(Subscription subscription)
        {
            return Result.Error;
        }
    }

    public enum Result
    {
        Error,
        Success,
    }
}
