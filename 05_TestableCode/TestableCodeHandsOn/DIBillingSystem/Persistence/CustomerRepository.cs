namespace DIBillingSystem.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using DIBillingSystem.Models;

    public class CustomerRepository
    {
        private readonly PostgresqlDatabase db;

        public CustomerRepository(PostgresqlDatabase db)
        {
            this.db = db;
        }

        public void Add(Customer customer)
        {
            this.db.Customers.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.db.Customers.AsEnumerable();
        }
    }
}
