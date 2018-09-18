namespace DIBillingSystem.Models
{
    using System;

    public class Subscription
    {
        public Customer subscriber { get; set; }

        public DateTime expirationDate { get; set; }
    }
}
