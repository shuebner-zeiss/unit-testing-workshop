using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2HandsOn._02;
using Moq;

namespace MockingHandsOnTests._02
{
    [TestClass]
    public class BillingSystemTests
    {
        private readonly Mock<ICharger> chargerMock = new Mock<ICharger>();

        private readonly Mock<ICustomerRepository> repoMock = new Mock<ICustomerRepository>();

        private BillingSystem billingSystem;

        [TestInitialize]
        public void Setup()
        {
            billingSystem = new BillingSystem(chargerMock.Object, repoMock.Object);
        }
    }
}
