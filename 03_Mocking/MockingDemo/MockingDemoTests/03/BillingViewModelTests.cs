using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingDemo._03;
using Moq;
using static MockingDemo._03.BillingViewModel;

namespace MockingDemoTests._03
{
    [TestClass]
    public class BillingViewModelTests
    {
        private BillingViewModel viewModel;

        private readonly Mock<IBillingSystem> billingSystemMock = new Mock<IBillingSystem>();

        [TestInitialize]
        public void Setup()
        {
            viewModel = new BillingViewModel(billingSystemMock.Object);
        }

        [TestMethod]
        public void SubmitForm_WhenFormIsValid_CallsBillingSystemProcess()
        {
        }

        [TestMethod]
        public void SubmitForm_WhenFormIsInvalid_DoesNotCallBillingSystemProcess()
        {
        }
    }
}
