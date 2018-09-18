using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAndInversion
{
    public interface IPaymentConnection
    {
        void MakeCreditCardPayment(string creditCardNumber, decimal amount);
    }
}
