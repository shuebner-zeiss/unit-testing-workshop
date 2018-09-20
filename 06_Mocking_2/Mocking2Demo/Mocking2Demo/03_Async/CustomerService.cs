using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mocking2Demo._03
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task ChangeNameAsync(Guid id, string newName)
        {
            return Task.CompletedTask;
        }
    }
}
