using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Model.Concrete;

namespace Strategy.Model.Abstract
{
    public interface IDeliveryCostCalculator
    {
        double CalculateDeliveryCost(Order order);
    }
}
