using Domain;
using DependencyInjectionAndInversion;
using System;

namespace App
{
    public static class DependencyInjectionAndInversionProgram
    {
        public static void Execute(Subscription subscription)
        {
            Console.WriteLine("With Dependency Inversion and dependency inversion");

            var subscriptionProcessor =
                new SubscriptionProcessor(
                    new CreditCardPaymentProcessor(
                        new DeutscheBankConnection()),
                    new CustomerProcessor(),
                    new Notifier());
            subscriptionProcessor.ProcessSubscription(subscription);

        }
    }
}
