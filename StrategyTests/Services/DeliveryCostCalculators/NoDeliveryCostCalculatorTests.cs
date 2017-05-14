using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy.Model.Concrete;
using Strategy.Services.DeliveryCostCalculators;

namespace StrategyTests.Services.DeliveryCostCalculators
{
    [TestClass]
    public class NoDeliveryCostCalculatorTests
    {
        private Order _order;
        [TestInitialize]
        public void Initialise()
        {
            _order = new Order(new List<Pizza> { new Pizza(), new Pizza() });
        }

        [TestMethod]
        public void CalculateDeliveryCosts_Returns_000()
        {
            //Arrange
            var costCalculator = new NoDeliveryCostCalculator();

            //Act
            var cost = costCalculator.CalculateDeliveryCost(_order);

            //Assert
            Assert.AreEqual(0.00, cost);
        }
    }
}
