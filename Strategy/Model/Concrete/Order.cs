using System.Collections.Generic;

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
