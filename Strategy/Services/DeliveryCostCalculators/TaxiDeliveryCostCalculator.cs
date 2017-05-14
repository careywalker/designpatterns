using Strategy.Model.Abstract;
using Strategy.Model.Concrete;

namespace Strategy.Services.DeliveryCostCalculators
{
    public class TaxiDeliveryCostCalculator : IDeliveryCostCalculator
    {
        public double CalculateDeliveryCost(Order order)
        {
            return order.Pizzas.Count * 1.00d + 10.00d;
        }
    }
}
