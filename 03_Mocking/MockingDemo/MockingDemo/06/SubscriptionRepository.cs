using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._06
{
    public class SubscriptionRepository
    {
        private readonly IDatabase database;

        public SubscriptionRepository(IDatabase database)
        {
            this.database = database;
        }

        public void Save(Subscription subscription)
        {
        }
    }
}
