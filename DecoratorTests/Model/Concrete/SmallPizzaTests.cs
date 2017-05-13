using Decorator.Model.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.Concrete
{
    [TestClass]
    public class SmallPizzaTests
    {
        [TestMethod]
        public void GetDescription_Returns_SmallPizza()
        {
            //Arrange
            var smallPizza = new SmallPizza();

            //Act
            var description = smallPizza.GetDescription();

            //Assert
            Assert.AreEqual(description, "Small Pizza");
        }

        [TestMethod]
        public void CalculateCost_Returns_3()
        {
            //Arrange
            var smallPizza = new SmallPizza();

            //Act
            var cost = smallPizza.CalculateCost();

            //Assert
            Assert.AreEqual(cost, 3.00);
        }
    }
}
