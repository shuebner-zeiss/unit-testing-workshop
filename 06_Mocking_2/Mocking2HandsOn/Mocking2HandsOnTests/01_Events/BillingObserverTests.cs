using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2HandsOn._01;
using Moq;

namespace Mocking2HandsOnTests._01
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
        public void BeforeStartObserving_WhenBillingDueIsRaised_DoesNotCallBillingSystem()
        {
        }

        [TestMethod]
        public void AfterStartObserving_WhenBillingDueIsRaised_CallsBillingSystemProcess()
        {
        }

        [TestMethod]
        public void AfterStartObservingThenStopObserving_WhenBillingDueIsRaised_DoesNotCallBillingSystem()
        {
        }
    }
}
