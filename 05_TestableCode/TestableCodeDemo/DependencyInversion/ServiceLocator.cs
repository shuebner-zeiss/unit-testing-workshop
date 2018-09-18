using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public static class ServiceLocator
    {
        public static SubscriptionProcessor GetSubscriptionProcessor()
        {
            return new SubscriptionProcessor();
        }

        public static IPaymentProcessor GetPaymentProcessor()
        {
            return new CreditCardPaymentProcessor();
        }

        public static IPaymentConnection GetPaymentConnection()
        {
            return new DeutscheBankConnection();
        }

        public static ICustomerProcessor GetCustomerProcessor()
        {
            return new CustomerProcessor();
        }

        public static INotifier GetNotifier()
        {
            return new Notifier();
        }
    }
}
