using System;
using Domain;

namespace DependencyInversion
{
    public class CustomerProcessor : ICustomerProcessor
    {
        public void UpdateCustomerSubscriptions(Subscription subscription)
        {
            Console.WriteLine($"Updated customer subscription for \"{subscription.CustomerName}\" with \"{subscription.Product}\".");
        }
    }
}