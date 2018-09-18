using System;
using Domain;

namespace StartingPoint
{
    public class Notifier
    {
        public void SendReceipt(Subscription subscription)
        {
            Console.Write($"Sending receipt about ${subscription.InitialFee} to \"{subscription.Email}\"...");
            Console.WriteLine("done!");
        }
    }
}