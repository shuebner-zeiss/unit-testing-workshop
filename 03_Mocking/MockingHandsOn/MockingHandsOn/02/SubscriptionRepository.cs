using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingHandsOn._02
{
    public class SubscriptionRepository
    {
        private readonly IDatabase db;

        public SubscriptionRepository(IDatabase db)
        {
            this.db = db;
        }

        public void Save(Subscription user)
        {
        }
    }

    public interface IDatabase
    {
        void Save(SubscriptionDbo user);
    }

    public class SubscriptionDbo
    {
        public string Product { get; set; }
        public decimal InitialFee { get; set; }
        public decimal RecurringFee { get; set; }
    }
}
