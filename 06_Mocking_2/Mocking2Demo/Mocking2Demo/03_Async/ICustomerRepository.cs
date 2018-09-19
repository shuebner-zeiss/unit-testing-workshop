using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2Demo._03
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}
