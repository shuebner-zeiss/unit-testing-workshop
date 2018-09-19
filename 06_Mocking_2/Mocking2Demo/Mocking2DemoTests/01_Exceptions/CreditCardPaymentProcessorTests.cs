using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2Demo._01;
using Moq;

namespace Mocking2DemoTests._01
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
        public void ProcessPayment_WhenPaymentConnectionThrowsCardOverdrawnException_ReturnsError()
        {
        }

        [TestMethod]
        public void ProcessPayment_WhenPaymentConnectionDoesNotThrowException_ReturnsSuccess()
        {
        }
    }
}
