using Decorator.Model.Concrete;
using Decorator.Model.ConcreteDecorators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.ConcreteDecorators
{
    [TestClass]
    public class CheeseTests
    {
        private LargePizza _largePizza;

        [TestInitialize]
        public void Initialise()
        {
            _largePizza = new LargePizza();
        }

        [TestMethod]
        public void GetDescription_Returns_Cheese()
        {
            //Arrange
            var cheeseDecorator = new CheeseDecorator(_largePizza);

            //Act
            var description = cheeseDecorator.GetDescription();

            //Assert
            Assert.AreEqual("Large Pizza, Cheese", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_1025()
        {
            //Arrange
            var cheeseDecorator = new CheeseDecorator(_largePizza);

            //Act
            var cost = cheeseDecorator.CalculateCost();

            //Assert
            Assert.AreEqual(10.25, cost);
        }
    }
}
