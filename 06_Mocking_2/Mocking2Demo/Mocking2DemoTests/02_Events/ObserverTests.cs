using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2Demo._02;
using Moq;

namespace Mocking2DemoTests._02
{
    [TestClass]
    public class ObserverTests
    {
        private readonly Mock<INotifier> notifierMock = new Mock<INotifier>();

        private Observer observer;

        [TestInitialize]
        public void Setup()
        {
            observer = new Observer(notifierMock.Object);
        }

        [TestMethod]
        public void BeforeStartObserving_WhenSomeEventIsRaised_LastNotificationIsNull()
        {
        }

        [TestMethod]
        public void AfterStartObserving_WhenNoEventIsRaised_LastNotificationIsNull()
        {
        }

        [TestMethod]
        public void AfterStartObserving_WhenSomeEventIsRaised_LastNotificationIsNotificationFromEvent()
        {
        }
    }
}
