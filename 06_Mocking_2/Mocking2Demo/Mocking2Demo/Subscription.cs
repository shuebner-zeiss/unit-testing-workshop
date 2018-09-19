using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2Demo
{
    public class Subscription
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Product { get; set; }
        public decimal InitialFee { get; set; }
        public decimal RecurringFee { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
