﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Template.Model.Abstract
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

        public void BakePizza()
        {
            Console.WriteLine("All pizzas are baked the same");
        }

        public void BoxPizza()
        {
            Console.WriteLine("All pizzas are put in the box the same way");
        }

        public void DeliverPizza()
        {
            Console.WriteLine("All pizzas are delivered the same");
        }
    }
}