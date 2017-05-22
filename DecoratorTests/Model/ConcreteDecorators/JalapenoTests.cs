using Decorator.Model.Concrete;
using Decorator.Model.ConcreteDecorators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.ConcreteDecorators
{
    [TestClass]
    public class JalapenoTests
    {
        private LargePizza _largePizza;

        [TestInitialize]
        public void Initialise()
        {
            _largePizza = new LargePizza();
        }

        [TestMethod]
        public void GetDescription_Returns_Jalapeno()
        {
            //Arrange
            var jalapenoDecorator = new JalapenoDecorator(_largePizza);

            //Act
            var description = jalapenoDecorator.GetDescription();

            //Assert
            Assert.AreEqual("Large Pizza, Jalapeno", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_1100()
        {
            //Arrange
            var jalapenoDecorator = new JalapenoDecorator(_largePizza);

            //Act
            var cost = jalapenoDecorator.CalculateCost();

            //Assert
            Assert.AreEqual(11.25, cost);
        }
    }
}
