using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Strategy.Model.Abstract;
using Strategy.Model.Concrete;
using Strategy.Services;

namespace StrategyTests.Services
{
    [TestClass]
    public class DeliveryCostCalculationServiceTests
    {
        [TestMethod]
        public void CalculateDeliveryCost_Returns_Cost()
        {
            //Arrange
            var order = new Order(new List<Pizza>());
            var deliveryCostCalculator = new Mock<IDeliveryCostCalculator>();
            deliveryCostCalculator.Setup(mock => mock.CalculateDeliveryCost(It.IsAny<Order>())).Returns(1.00);
            var service = new DeliveryCostCalculationService(deliveryCostCalculator.Object);

            //Act
            var cost = service.CalculateDeliveryCost(order);

            //Assert
            Assert.AreEqual(1.00, cost);
        }
    }
}
