namespace DIBillingSystem
{
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Repositories;

    public class BillingSystem
    {
        private readonly PostgresqlDatabase db;
        private readonly ICharger charger;
        private CustomerRepository customerRepository;

        public BillingSystem(PostgresqlDatabase db, ICharger charger)
        {
            this.db = db;
            this.charger = charger; // good!
            // where is the subscription-repository?
        }

        public void Init() // bad!
        {
            this.customerRepository = new CustomerRepository(this.db); // bad!
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