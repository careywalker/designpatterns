using Decorator.Model.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.Concrete
{
    [TestClass]
    public class LargePizzaTests
    {
        [TestMethod]
        public void GetDescription_Returns_LargePizza()
        {
            //Arrange
            var largePizza = new LargePizza();

            //Act
            var description = largePizza.GetDescription();

            //Assert
            Assert.AreEqual("Large Pizza", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_9()
        {
            //Arrange
            var largePizza = new LargePizza();

            //Act
            var cost = largePizza.CalculateCost();

            //Assert
            Assert.AreEqual(9.00, cost);
        }
    }
}
