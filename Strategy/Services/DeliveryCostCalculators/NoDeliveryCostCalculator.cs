using Strategy.Model.Abstract;
using Strategy.Model.Concrete;

namespace Strategy.Services.DeliveryCostCalculators
{
    public class NoDeliveryCostCalculator : IDeliveryCostCalculator
    {
        public double CalculateDeliveryCost(Order order)
        {
            return 0.00d;
        }
    }
}
