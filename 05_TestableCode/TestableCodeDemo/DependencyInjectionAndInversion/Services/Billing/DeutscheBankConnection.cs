using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAndInversion
{
    public class DeutscheBankConnection : IPaymentConnection
    {
        public void MakeCreditCardPayment(string creditCardNumber, decimal amount)
        {
            Console.WriteLine("Connecting to Deutsche Bank...");
            Console.WriteLine("Making Payment...");
            Console.WriteLine("Connection Closed");
        }
    }
}
