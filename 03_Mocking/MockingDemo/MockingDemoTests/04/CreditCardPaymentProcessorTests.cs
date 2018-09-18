using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._04;
using Moq;

namespace MockingDemoTests._04
{
    [TestClass]
    public class CreditCardPaymentProcessorTests
    {
        [TestMethod]
        public void Process_WhenSubscriptionInitialFeeIsGreaterThanZero_CallsMakeCreditCardPaymentWithSubscriptionData()
        {
        }

        public void Process_WhenSubscriptionInitialFeeIsZero_DoesNotCallMakeCreditCardPayment()
        {
        }
    }
}
