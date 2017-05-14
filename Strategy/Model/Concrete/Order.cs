using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model.Concrete
{
    public class Order
    {
        public Order(List<Pizza> pizzas)
        {
            Pizzas = pizzas;
        }

        public List<Pizza> Pizzas { get; private set; }
    }
}
