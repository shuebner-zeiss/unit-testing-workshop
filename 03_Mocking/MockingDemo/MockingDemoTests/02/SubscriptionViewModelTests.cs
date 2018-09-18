using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._02;
using Moq;

namespace MockingDemoTests._02
{
    [TestClass]
    public class SubscriptionViewModelTests
    {
        [TestMethod]
        public void IsSubscribed_WhenStatusSourceStatusIsNone_ReturnsFalse()
        {
        }

        [TestMethod]
        public void IsSubscribed_WhenStatusSourceStatusIsSubscribed_ReturnsTrue()
        {
        }

        [TestMethod]
        public void IsSubscribed_WhenStatusSourceStatusIsUnsubscribed_ReturnsFalse()
        {
        }
    }
}
