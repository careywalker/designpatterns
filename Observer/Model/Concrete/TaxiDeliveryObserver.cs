using System;

namespace Observer.Model.Concrete
{
    public class TaxiDeliveryObserver : Abstract.Observer
    {
        private DeliveryManagerSubject DeliveryManagerSubject { get; set; }
        public int TotalDeliveries { get; private set; }

        public TaxiDeliveryObserver(DeliveryManagerSubject deliveryManagerSubject)
        {
            DeliveryManagerSubject = deliveryManagerSubject;
            deliveryManagerSubject.Register(this);
        }

        public override void Update()
        {
            var customerName = DeliveryManagerSubject.Delivery.CustomerName;
            var deliveryType = DeliveryManagerSubject.Delivery.DeliveryType;

            if (deliveryType == DeliveryType.Taxi)
            {
                Console.WriteLine($"Order for: {customerName} is ready for delivery by: {deliveryType}");
                TotalDeliveries++;
            }
        }
    }
}
