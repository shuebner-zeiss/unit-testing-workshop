using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._04
{
    public interface IPaymentConnection
    {
        void MakeCreditCardPayment(string creditCardNumber, decimal amount);
    }
}
