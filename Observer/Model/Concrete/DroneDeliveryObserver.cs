using System;

namespace Observer.Model.Concrete
{
    public class DroneDeliveryObserver : Abstract.Observer
    {
        private DeliveryManagerSubject DeliveryManagerSubject { get; set; }
        public int TotalDeliveries { get; private set; }

        public DroneDeliveryObserver(DeliveryManagerSubject deliveryManagerSubject)
        {
            DeliveryManagerSubject = deliveryManagerSubject;
            deliveryManagerSubject.Register(this);
        }

        public override void Update()
        {
            var customerName = DeliveryManagerSubject.Delivery.CustomerName;
            var deliveryType = DeliveryManagerSubject.Delivery.DeliveryType;

            if (deliveryType == DeliveryType.Drone)
            {
                Console.WriteLine($"Order for: {customerName} is ready for delivery by: {deliveryType}");
                TotalDeliveries++;
            }
        }
    }
}
