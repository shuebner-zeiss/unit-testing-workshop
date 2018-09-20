using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mocking2Demo._03;
using Moq;

namespace Mocking2DemoTests._03
{
    [TestClass]
    public class CustomerServiceTests
    {
        private CustomerService customerService;

        private readonly Mock<ICustomerRepository> customerRepositoryMock = new Mock<ICustomerRepository>();

        [TestInitialize]
        public void Setup()
        {
            customerService = new CustomerService(customerRepositoryMock.Object);
        }

        [TestMethod]
        public async Task ChangeName_WhenCustomerExists_SavesCustomerWithNewName()
        {
        }
    }
}
