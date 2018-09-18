using System;
using Domain;

namespace StartingPoint
{
    public class CustomerProcessor
    {
        public void UpdateCustomerSubscriptions(Subscription subscription)
        {
            Console.WriteLine($"Updated customer subscription for \"{subscription.CustomerName}\" with \"{subscription.Product}\".");
        }
    }
}