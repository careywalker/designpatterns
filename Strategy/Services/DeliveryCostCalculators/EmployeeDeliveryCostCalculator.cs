﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Model.Abstract;
using Strategy.Model.Concrete;

namespace Strategy.Services.DeliveryCostCalculators
{
    public class EmployeeDeliveryCostCalculator : IDeliveryCostCalculator
    {
        public double CalculateDeliveryCost(Order order)
        {
            return order.Pizzas.Count * 1.00d;
        }
    }
}