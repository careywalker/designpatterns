using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Observer.Model.Concrete;

namespace ObserverTests.Model.Concrete
{
    [TestClass]
    public class EmployeeDeliveryObserverTests
    {
        [TestMethod]
        public void Update_Increments_TotalDeliveries()
        {
            //Arrange
            var subject = new Mock<DeliveryManagerSubject>();
            subject.Object.Delivery = new Delivery
            {
                DeliveryType = DeliveryType.Employee,
                CustomerName = "Test Customer"
            };
            var observer = new EmployeeDeliveryObserver(subject.Object);

            //Act
            observer.Update();

            //Assert
            Assert.AreEqual(1, observer.TotalDeliveries);
        }
    }
}
