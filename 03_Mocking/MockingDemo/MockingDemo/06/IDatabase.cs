using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._06
{
    public interface IDatabase
    {
        void Save(SubscriptionDbo subscriptionDbo);
    }

    public class SubscriptionDbo
    {
        public string Product { get; set; }
        public decimal InitialFee { get; set; }
        public decimal RecurringFee { get; set; }
    }
}
