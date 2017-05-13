using Decorator.Model.Concrete;
using Decorator.Model.Decorators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.Decorators
{
    [TestClass]
    public class PizzaDecoratorTests
    {
        private LargePizza _largePizza;

        [TestInitialize]
        public void Initialise()
        {
            _largePizza = new LargePizza();
        }

        [TestMethod]
        public void GetDescription_Returns_Description()
        {
            //Arrange
            var pizzaDecorator = new PizzaDecorator(_largePizza);

            //Act
            var description = pizzaDecorator.GetDescription();

            //Assert
            Assert.AreEqual("Large Pizza", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_Cost()
        {
            //Arrange
            var pizzaDecorator = new PizzaDecorator(_largePizza);

            //Act
            var cost = pizzaDecorator.CalculateCost();

            //Assert
            Assert.AreEqual(9.00, cost);
        }
    }
}
