using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingHandsOn._01
{
    public class PriceCalculator
    {
        private readonly ICustomerService customerService;

        private readonly IDiscountProvider discountProvider;

        public PriceCalculator(ICustomerService customerService, IDiscountProvider discountProvider)
        {
            this.customerService = customerService;
            this.discountProvider = discountProvider;
        }

        public decimal CalculatePrice(Customer customer, Subscription subscription)
        {
            return 0m;
        }
    }

    public interface ICustomerService
    {
        bool IsEligibleForDiscount(Customer customer);

        void RecordDiscount(Customer customer);
    }

    public interface IDiscountProvider
    {
        decimal GetDiscountedPrice(Subscription subscription);
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
