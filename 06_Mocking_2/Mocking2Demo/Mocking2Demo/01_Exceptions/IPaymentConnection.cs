using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2Demo._01
{
    public interface IPaymentConnection
    {
        /// <exception cref="CreditCardOverdrawnException"></exception>
        void MakeCreditCardPayment(string creditCardNumber, decimal amount);
    }

    public class CreditCardOverdrawnException : Exception
    {
    }
}
