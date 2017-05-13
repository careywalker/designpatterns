using Decorator.Model.Concrete;
using Decorator.Model.ConcreteDecorators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.ConcreteDecorators
{
    [TestClass]
    public class PepperoniTests
    {
        private LargePizza _largePizza;

        [TestInitialize]
        public void Initialise()
        {
            _largePizza = new LargePizza();
        }

        [TestMethod]
        public void GetDescription_Returns_Pepperoni()
        {
            //Arrange
            var pepperoniDecorator = new Pepperoni(_largePizza);

            //Act
            var description = pepperoniDecorator.GetDescription();

            //Assert
            Assert.AreEqual("Large Pizza, Pepperoni", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_1075()
        {
            //Arrange
            var pepperoniDecorator = new Pepperoni(_largePizza);

            //Act
            var cost = pepperoniDecorator.CalculateCost();

            //Assert
            Assert.AreEqual(10.75, cost);
        }
    }
}
