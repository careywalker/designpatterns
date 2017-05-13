using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Model.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests.Model.Concrete
{
    [TestClass]
    public class MediumPizzaTests
    {
        [TestMethod]
        public void GetDescription_Returns_MediumPizza()
        {
            //Arrange
            var mediumPizza = new MediumPizza();

            //Act
            var description = mediumPizza.GetDescription();

            //Assert
            Assert.AreEqual("Medium Pizza", description);
        }

        [TestMethod]
        public void CalculateCost_Returns_6()
        {
            //Arrange
            var mediumPizza = new MediumPizza();

            //Act
            var cost = mediumPizza.CalculateCost();

            //Assert
            Assert.AreEqual(6.00, cost);
        }
    }
}
