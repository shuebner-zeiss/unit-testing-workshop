using System;
using Domain;

namespace DependencyInjectionAndInversion
{
    public class Notifier : INotifier
    {
        public void SendReceipt(Subscription subscription)
        {
            Console.Write($"Sending receipt about ${subscription.InitialFee} to \"{subscription.Email}\"...");
            Console.WriteLine("done!");
        }
    }
}