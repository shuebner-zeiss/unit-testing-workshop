namespace DIBillingSystem.Repositories
{
    using System.Linq;
    using DIBillingSystem.Models;

    public class SubscriptionRepository
    {
        private readonly PostgresqlDatabase db;

        public SubscriptionRepository(PostgresqlDatabase db)
        {
            this.db = db;
        }

        public void Add(Subscription subscription)
        {
            this.db.Subscriptions.Add(subscription);
        }

        public Subscription GetBySubscriber(Customer subscriber)
        {
            return this.db.Subscriptions.Single(subscription => subscription.subscriber == subscriber);
        }
    }
}
