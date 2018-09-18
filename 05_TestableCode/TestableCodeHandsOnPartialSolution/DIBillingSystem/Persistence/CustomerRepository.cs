﻿namespace DIBillingSystem.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerDatabase db;

        public CustomerRepository(ICustomerDatabase db)
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
