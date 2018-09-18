namespace DIBillingSystem.Repositories
{
    using System.Linq;
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;

    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly ISubscriptionDatabase db;

        public SubscriptionRepository(ISubscriptionDatabase db)
        {
            this.db = db;
        }

        public void Add(Subscription subscription)
        {
            this.db.Subscriptions.Add(subscription);
        }

        public Subscription GetBySubscriber(Customer subscriber)
        {
            return this.db.Subscriptions.SingleOrDefault(subscription => subscription.subscriber == subscriber);
        }
    }
}
