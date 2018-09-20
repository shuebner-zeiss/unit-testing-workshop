using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._04;
using Moq;

namespace MockingDemoTests._04
{
    [TestClass]
    public class CreditCardPaymentProcessorTests
    {
        private readonly Mock<IPaymentConnection> paymentConnectionMock = new Mock<IPaymentConnection>();

        private CreditCardPaymentProcessor processor;

        [TestInitialize]
        public void Setup()
        {
            processor = new CreditCardPaymentProcessor(paymentConnectionMock.Object);
        }

        [TestMethod]
        public void Process_WhenSubscriptionInitialFeeIsGreaterThanZero_CallsMakeCreditCardPaymentWithSubscriptionData()
        {
        }

        [TestMethod]
        public void Process_WhenSubscriptionInitialFeeIsZero_DoesNotCallMakeCreditCardPayment()
        {
        }

        [TestMethod]
        public void Process_WhenPaymentConnectionReturnsStatusCodeMinusOne_ReturnsError()
        {
        }

        [TestMethod]
        public void Process_WhenPaymentConnectionReturnsPositiveStatusCode_ReturnsSuccess()
        {
        }
    }
}
