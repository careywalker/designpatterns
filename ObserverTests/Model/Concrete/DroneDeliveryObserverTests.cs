using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Observer.Model.Concrete;

namespace ObserverTests.Model.Concrete
{
    [TestClass]
    public class DroneDeliveryObserverTests
    {
        [TestMethod]
        public void Update_Increments_TotalDeliveries()
        {
            //Arrange
            var mockSubject = new Mock<DeliveryManagerSubject>();
            mockSubject.Object.Delivery = new Delivery
            {
                DeliveryType = DeliveryType.Drone,
                CustomerName = "Test Customer"
            };
            var observer = new DroneDeliveryObserver(mockSubject.Object);

            //Act
            observer.Update();

            //Assert
            Assert.AreEqual(1, observer.TotalDeliveries);
        }
    }
}
