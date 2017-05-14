using System;

namespace Observer.Model.Concrete
{
    public class EmployeeDeliveryObserver : Abstract.Observer
    {
        private DeliveryManagerSubject DeliveryManagerSubject { get; set; }
        public int TotalDeliveries { get; private set; }

        public EmployeeDeliveryObserver(DeliveryManagerSubject deliveryManagerSubject)
        {
            DeliveryManagerSubject = deliveryManagerSubject;
            deliveryManagerSubject.Register(this);
        }

        public override void Update()
        {
            var customerName = DeliveryManagerSubject.Delivery.CustomerName;
            var deliveryType = DeliveryManagerSubject.Delivery.DeliveryType;

            if (deliveryType == DeliveryType.Employee)
            {
                Console.WriteLine($"Order for: {customerName} is ready for delivery by: {deliveryType}");
                TotalDeliveries++;
            }
        }
    }
}
