using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2Demo._03;
using Moq;

namespace Mocking2DemoTests._03
{
    [TestClass]
    public class BillingSystemTests
    {
        private BillingSystem copier;

        private readonly Mock<ICharger> chargerMock = new Mock<ICharger>();

        private readonly Mock<ICustomerRepository> repoMock = new Mock<ICustomerRepository>();

        [TestInitialize]
        public void Setup()
        {
            copier = new BillingSystem(chargerMock.Object, repoMock.Object);
        }
    }
}
