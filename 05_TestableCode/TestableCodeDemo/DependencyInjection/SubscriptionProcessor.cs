using Domain;

namespace DependencyInjection
{
    public class SubscriptionProcessor
    {
        private readonly PaymentProcessor _paymentProcessor;
        private readonly CustomerProcessor _customerProcessor;
        private readonly Notifier _notifier;

        public SubscriptionProcessor(
            PaymentProcessor paymentProcessor,
            CustomerProcessor customerProcessor,
            Notifier notifier)
        {
            _paymentProcessor = paymentProcessor;
            _customerProcessor = customerProcessor;
            _notifier = notifier;
        }

        public void ProcessSubscription(Subscription subscription)
        {
            _paymentProcessor.ProcessPayment(subscription);
            _customerProcessor.UpdateCustomerSubscriptions(subscription);
            _notifier.SendReceipt(subscription);
        }
    }
}
