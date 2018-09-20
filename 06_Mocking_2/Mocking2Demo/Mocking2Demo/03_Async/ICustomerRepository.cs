using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mocking2Demo._03
{
    public interface ICustomerRepository
    {
        Task<Customer> GetAsync(Guid id);

        Task SaveAsync(Customer customer);
    }
}
