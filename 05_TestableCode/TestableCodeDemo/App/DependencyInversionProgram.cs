using Domain;
using System;
using DependencyInversion;

namespace App
{
    public static class DependencyInversionProgram
    {
        public static void Execute(Subscription subscription)
        {
            Console.WriteLine("With Dependency Inversion");

            var subscriptionProcessor = new SubscriptionProcessor();
            subscriptionProcessor.ProcessSubscription(subscription);
        }
    }
}
