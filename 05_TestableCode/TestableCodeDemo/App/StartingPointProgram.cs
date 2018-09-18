using Domain;
using System;
using StartingPoint;

namespace App
{
    public static class StartingPointProgram
    {
        public static void Execute(Subscription subscription)
        {
            Console.WriteLine("starting point without dependency injection and without dependency inversion");

            var subscriptionProcessor = new SubscriptionProcessor();
            subscriptionProcessor.ProcessSubscription(subscription);
        }
    }
}
