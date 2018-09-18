namespace DIBillingSystem.Tests
{
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;
    using DIBillingSystem.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class BillingSystemTests
    {
        private BillingSystem billingSystem;

        private Mock<ICustomerRepository> customerRepoMock;

        private Mock<ISubscriptionRepository> subscriptionRepoMock;

        private Mock<ICharger> chargerMock;

        [TestInitialize]
        public void Setup()
        {
            customerRepoMock = new Mock<ICustomerRepository>();
            subscriptionRepoMock = new Mock<ISubscriptionRepository>();
            chargerMock = new Mock<ICharger>();
            billingSystem = new BillingSystem(customerRepoMock.Object, subscriptionRepoMock.Object, chargerMock.Object);            
        }

        [TestMethod]
        public void bla()
        {
            customerRepoMock.Setup(repo => repo.GetAll()).Returns(new[] { new Customer() });
        }
    }
}
