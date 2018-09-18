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
        private PostgresqlDatabase db;
        private Mock<ICharger> chargerMock;

        [TestInitialize]
        public void Setup()
        {
            this.db = new PostgresqlDatabase(); // try to get rid of me
            this.chargerMock = new Mock<ICharger>();
            this.billingSystem = new BillingSystem(this.db, this.chargerMock.Object);
            this.billingSystem.Init();
        }

        [TestCleanup]
        public void Cleanup() // try to get rid of me
        {
            this.db.Customers.Clear();
            this.db.Subscriptions.Clear();
        }

        [TestMethod]
        public void ProcessMonth_GivenCustomerWitSubscription_CallsCharger()
        {
            var customer = new Customer();
            this.db.Customers.Add(customer); // bad! use repositories instead!
            this.db.Subscriptions.Add(new Subscription { subscriber = customer });

            this.billingSystem.Process();

            this.chargerMock.Verify(mock => mock.Charge(customer), Times.Once);
        }

        [TestMethod]
        public void ProcessMonth_GivenCustomerWitoutSubscription_DoesNotCallCharger()
        {
            var customer = new Customer();
            this.db.Customers.Add(customer); // bad! use repositories instead!

            this.billingSystem.Process();

            this.chargerMock.Verify(mock => mock.Charge(customer), Times.Never);
        }
    }
}
