﻿using System;

namespace TemplateMethod.Model.Abstract
{
    public abstract class PizzaOrder
    {
        public string CustomerName { get; set; }

        public void ProcessOrder()
        {
            MakePizza();
            BakePizza();
            BoxPizza();
            DeliverPizza();
        }

        public abstract void MakePizza();

        private void BakePizza()
        {
            Console.WriteLine("All pizzas are baked the same");
        }

        private void BoxPizza()
        {
            Console.WriteLine("All pizzas are put in the box the same way");
        }

        private void DeliverPizza()
        {
            Console.WriteLine("All pizzas are delivered the same");
        }
    }
}
