using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2HandsOn._02
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}
