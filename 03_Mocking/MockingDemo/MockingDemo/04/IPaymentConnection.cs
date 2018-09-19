using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._04
{
    public interface IPaymentConnection
    {
        /// <returns>status code, -1 for error</returns>
        int MakeCreditCardPayment(string creditCardNumber, decimal amount);
    }
}
