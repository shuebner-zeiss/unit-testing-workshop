using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._06;
using Moq;

namespace MockingDemoTests._06
{
    [TestClass]
    public class DataSeederTests
    {
        private DataSeeder seeder;

        private readonly Mock<IDatabase> storageMock = new Mock<IDatabase>();

        [TestInitialize]
        public void Setup()
        {
            seeder = new DataSeeder(storageMock.Object);
        }

        [TestMethod]
        public void SeedData_CallsStoreWithFilledBar()
        {
        }
    }
}
