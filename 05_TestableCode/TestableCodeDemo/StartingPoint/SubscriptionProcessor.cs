using Domain;

namespace StartingPoint
{
    public class SubscriptionProcessor
    {
        public void ProcessSubscription(Subscription subscription)
        {
            var paymentProcessor = new PaymentProcessor();
            var customerProcessor = new CustomerProcessor();
            var notifier = new Notifier();

            paymentProcessor.ProcessPayment(subscription);
            customerProcessor.UpdateCustomerSubscriptions(subscription);
            notifier.SendReceipt(subscription);
        }
    }
}
