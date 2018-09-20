using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._06;
using Moq;

namespace MockingDemoTests._06
{
    [TestClass]
    public class SubscriptionRepositoryTests
    {
        private SubscriptionRepository subscriptionRepository;

        private readonly Mock<IDatabase> databaseMock = new Mock<IDatabase>();

        private readonly Mock<IDatabase> storageMock = new Mock<IDatabase>();

        [TestInitialize]
        public void Setup()
        {
            subscriptionRepository = new SubscriptionRepository(databaseMock.Object);
        }

        [TestMethod]
        public void Save_SavesMappedDboInDatabase___WithMoqItIs()
        {
        }

        [TestMethod]
        public void Save_SavesMappedDboInDatabase___WithMoqCallbackAndAssertions()
        {
        }
    }
}
