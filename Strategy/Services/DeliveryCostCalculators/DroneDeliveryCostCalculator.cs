using Strategy.Model.Abstract;
using Strategy.Model.Concrete;

namespace Strategy.Services.DeliveryCostCalculators
{
    public class DroneDeliveryCostCalculator : IDeliveryCostCalculator
    {
        public double CalculateDeliveryCost(Order order)
        {
            return order.Pizzas.Count * 2.00d;
        }
    }
}
