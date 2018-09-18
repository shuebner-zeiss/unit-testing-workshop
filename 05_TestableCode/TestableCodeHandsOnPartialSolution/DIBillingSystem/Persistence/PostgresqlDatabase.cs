namespace DIBillingSystem.Repositories
{
    using System.Collections.Generic;
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;

    public class PostgresqlDatabase
        : ICustomerDatabase, ISubscriptionDatabase
    {
        public IList<Customer> Customers { get; } = new List<Customer>();
        public IList<Subscription> Subscriptions { get; } = new List<Subscription>();
    }
}