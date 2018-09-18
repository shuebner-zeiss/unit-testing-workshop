using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAndInversion
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(Subscription subscription);
    }
}
