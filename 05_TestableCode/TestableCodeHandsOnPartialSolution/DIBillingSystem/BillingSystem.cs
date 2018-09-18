namespace DIBillingSystem
{
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Repositories;

    public class BillingSystem
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ISubscriptionRepository subscriptionRepository;
        private readonly ICharger charger;

        public BillingSystem(
            ICustomerRepository customerRepository,
            ISubscriptionRepository subscriptionRepository,
            ICharger charger)
        {
            this.customerRepository = customerRepository;
            this.subscriptionRepository = subscriptionRepository;
            this.charger = charger;
        }

        public void Process()
        {
            var customers = this.customerRepository.GetAll();
            foreach (var customer in customers)
            {
                this.charger.Charge(customer);
            }
        }
    }
}