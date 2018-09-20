using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingHandsOn;
using MockingHandsOn._01;
using Moq;

namespace MockingHandsOnTests._01
{
    [TestClass]
    public class PriceCalculatorTests
    {
        private readonly Mock<ICustomerService> customerServiceMock = new Mock<ICustomerService>();

        private readonly Mock<IDiscountProvider> discountProviderMock = new Mock<IDiscountProvider>();

        private PriceCalculator priceCalculator;

        [TestInitialize]
        public void Setup()
        {
            priceCalculator = new PriceCalculator(customerServiceMock.Object, discountProviderMock.Object);
        }

        [TestMethod]
        public void CalculatePrice_WhenCustomerIsEligibleForDiscount_ReturnsDiscountedPrice()
        {
        }
    }
}
