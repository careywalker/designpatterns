using System;
using Observer.Model.Concrete;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var deliveryManager = new DeliveryManagerSubject();

            var droneDelivery = new DroneDeliveryObserver(deliveryManager);
            var taxiDelivery = new TaxiDeliveryObserver(deliveryManager);
            var employeeDelivery = new EmployeeDeliveryObserver(deliveryManager);

            do
            {
                deliveryManager.Delivery = new Delivery
                {
                    CustomerName = $"Customer #{counter}",
                    DeliveryType = GetRandomDeliveryType()
                };
                counter++;
            } while (counter < 100);

            Console.WriteLine("All pizza orders have been delivered");
            Console.WriteLine($"Total Pizzas Deliveried: {counter}");
            Console.WriteLine($"Drone Deliveries: {droneDelivery.TotalDeliveries}");
            Console.WriteLine($"Taxi Deliveries: {taxiDelivery.TotalDeliveries}");
            Console.WriteLine($"Employee Deliveries: {employeeDelivery.TotalDeliveries}");
            Console.ReadKey();
        }

        private static DeliveryType GetRandomDeliveryType()
        {
            return (DeliveryType)new Random().Next(1, 4);
        }
    }
}
