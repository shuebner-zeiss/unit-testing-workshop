using Domain;

namespace DependencyInversion
{
    public class SubscriptionProcessor
    {
        public void ProcessSubscription(Subscription subscription)
        {
            IPaymentProcessor paymentProcessor = ServiceLocator.GetPaymentProcessor();
            ICustomerProcessor customerProcessor = ServiceLocator.GetCustomerProcessor();
            INotifier notifier = ServiceLocator.GetNotifier();

            paymentProcessor.ProcessPayment(subscription);
            customerProcessor.UpdateCustomerSubscriptions(subscription);
            notifier.SendReceipt(subscription);
        }
    }
}
