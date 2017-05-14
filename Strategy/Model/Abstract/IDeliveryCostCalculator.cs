using Strategy.Model.Concrete;

namespace Strategy.Model.Abstract
{
    public interface IDeliveryCostCalculator
    {
        double CalculateDeliveryCost(Order order);
    }
}
