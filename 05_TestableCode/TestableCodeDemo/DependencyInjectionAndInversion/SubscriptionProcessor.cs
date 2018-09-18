using Domain;

namespace DependencyInjectionAndInversion
{
    public class SubscriptionProcessor
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly ICustomerProcessor _customerProcessor;
        private readonly INotifier _notifier;

        public SubscriptionProcessor(
            IPaymentProcessor paymentProcessor,
            ICustomerProcessor customerProcessor,
            INotifier notifier)
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
