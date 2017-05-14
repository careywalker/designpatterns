using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Model.Concrete;
using Strategy.Services;
using Strategy.Services.DeliveryCostCalculators;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzas = new List<Pizza>
            {
                new Pizza(),
                new Pizza(),
                new Pizza()
            };
            var order = new Order(pizzas);


            //Calculate cost to deliver pizzas by drone
            var droneDeliveryCalculator = new DroneDeliveryCostCalculator();
            var droneDelivery = new DeliveryCostCalculationService(droneDeliveryCalculator);
            Console.WriteLine(
                $"Cost to deliver {order.Pizzas.Count} pizzas by Drone is: {droneDelivery.CalculateDeliveryCost(order)}");

            //Calculate cost to delivery pizzas by taxi
            var taxiDeliveryCalculator = new TaxiDeliveryCostCalculator();
            var taxiDelivery = new DeliveryCostCalculationService(taxiDeliveryCalculator);
            Console.WriteLine(
                $"Cost to deliver {order.Pizzas.Count} pizzas by Taxi is: {taxiDelivery.CalculateDeliveryCost(order)}");

            //Calculate cost to deliver pizzas by store employee
            var storeEmployeeDeliveryCalculator = new EmployeeDeliveryCostCalculator();
            var employeeDelivery = new DeliveryCostCalculationService(storeEmployeeDeliveryCalculator);
            Console.WriteLine(
                $"Cost to deliver {order.Pizzas.Count} pizzas by Store Employee is: {employeeDelivery.CalculateDeliveryCost(order)}");

            //Calculate cost to collect pizzas in store by customer
            var customerCollectionDeliveryCalculator = new NoDeliveryCostCalculator();
            var customerCollection = new DeliveryCostCalculationService(customerCollectionDeliveryCalculator);
            Console.WriteLine($"Cost to collect {order.Pizzas.Count} pizzas in store is: {customerCollection.CalculateDeliveryCost(order)}");

            Console.ReadKey();
        }
    }
}
