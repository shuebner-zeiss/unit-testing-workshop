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

        public void ProcessPayment(Subscription subscription)
        {
            return;
        }
    }
}
