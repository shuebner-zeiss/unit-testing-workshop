using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._06
{
    public class DataSeeder
    {
        private readonly IDatabase storage;

        public DataSeeder(IDatabase storage)
        {
            this.storage = storage;
        }

        public void SeedData()
        {
            this.storage.Store(new Subscription
            {
                CreditCardNumber = "1234567890123456",
                CustomerName = "Max Mustermann",
                Email = "max@mustermann.com",
                InitialFee = 10,
                RecurringFee = 5,
                Product = "Clean Code Magazine",
            });
        }
    }
}
