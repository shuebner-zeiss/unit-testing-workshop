﻿using DIBillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIBillingSystem.Abstractions
{
    public interface ICustomerDatabase
    {
        IList<Customer> Customers { get; }
    }
}
