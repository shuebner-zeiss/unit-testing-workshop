using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2Demo._02;
using Moq;

namespace Mocking2DemoTests._02
{
    [TestClass]
    public class BillingObserverTests
    {
        private readonly Mock<IBillingSystem> billingSystemMock = new Mock<IBillingSystem>();

        private readonly Mock<IBillingTriggerer> billingTriggererMock = new Mock<IBillingTriggerer>();

        private BillingObserver observer;

        [TestInitialize]
        public void Setup()
        {
            observer = new BillingObserver(billingSystemMock.Object, billingTriggererMock.Object);
        }

        [TestMethod]
        public void BeforeStartObserving_WhenBillingDueEventIsRaised_DoesNotStartBillingProcess()
        {
        }

        [TestMethod]
        public void AfterStartObserving_WhenBillingDueEventIsRaised_StartsBillingProcess()
        {
        }
    }
}
