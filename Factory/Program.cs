using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Model.Concrete;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactory = new PizzaFactory();
            var pizzaTypes = pizzaFactory.GetPizzaTypes();

            foreach (var pizzaType in pizzaTypes)
            {
                var pizza = pizzaFactory.CreateInstance(pizzaType.Key);
                pizza.Make();
                pizza.Bake();
                pizza.Deliver();
            }

            Console.ReadKey();
        }
    }
}
