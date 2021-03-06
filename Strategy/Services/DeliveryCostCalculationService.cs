﻿using Strategy.Model.Abstract;
using Strategy.Model.Concrete;

namespace Strategy.Services
{
    public class DeliveryCostCalculationService
    {
        private readonly IDeliveryCostCalculator _deliveryCostCalculator;

        public DeliveryCostCalculationService(IDeliveryCostCalculator deliveryCostCalculator)
        {
            _deliveryCostCalculator = deliveryCostCalculator;
        }

        public double CalculateDeliveryCost(Order order)
        {
            return _deliveryCostCalculator.CalculateDeliveryCost(order);
        }
    }
}
