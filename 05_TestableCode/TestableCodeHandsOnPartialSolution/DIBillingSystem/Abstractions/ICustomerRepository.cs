using DIBillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIBillingSystem.Abstractions
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();

        void Add(Customer entity);
    }
}
