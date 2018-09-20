using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mocking2HandsOn._02
{
    public class BillingSystem
    {
        private readonly ICharger charger;

        private readonly ICustomerRepository customerRepository;

        public BillingSystem(ICharger charger, ICustomerRepository customerRepository)
        {
            this.charger = charger;
            this.customerRepository = customerRepository;
        }

        public Task<Result> ProcessAsync()
        {
            return Task.FromResult(Result.Error);
        }
    }
}
