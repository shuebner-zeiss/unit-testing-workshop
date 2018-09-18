using DependencyInjection;
using Domain;
using System;

namespace App
{
    public static class DependencyInjectionProgram
    {
        public static void Execute(Subscription subscription)
        {
            Console.WriteLine("With Dependency Injection");

            var subscriptionProcessor =
                new SubscriptionProcessor(
                    new PaymentProcessor(
                        new BankConnection()),
                    new CustomerProcessor(),
                    new Notifier());
            subscriptionProcessor.ProcessSubscription(subscription);
        }
    }
}
