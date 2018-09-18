namespace DIBillingSystem.Repositories
{
    using System.Collections.Generic;
    using DIBillingSystem.Models;

    public class PostgresqlDatabase
    {
        public readonly IList<Customer> Customers = new List<Customer>();
        public readonly IList<Subscription> Subscriptions = new List<Subscription>();
    }
}