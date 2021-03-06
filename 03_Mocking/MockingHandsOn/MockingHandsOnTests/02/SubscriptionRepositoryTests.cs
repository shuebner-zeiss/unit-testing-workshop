﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingHandsOn;
using MockingHandsOn._02;
using Moq;

namespace MockingHandsOnTests._02
{
    [TestClass]
    public class SubscriptionRepositoryTests
    {
        private readonly Mock<IDatabase> databaseMock = new Mock<IDatabase>();

        private SubscriptionRepository subscriptionRepository;

        [TestInitialize]
        public void Setup()
        {
            subscriptionRepository = new SubscriptionRepository(databaseMock.Object);
        }

        [TestMethod]
        public void Save_SavesMappedSubscriptionDbo___WithMoqItIs()
        {
        }

        [TestMethod]
        public void Save_SavesMappedSubscriptionDbo___WithMoqCallbackAndAssertions()
        {
        }
    }
}
