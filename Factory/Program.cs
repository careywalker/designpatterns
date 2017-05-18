using System;
using Factory.Infrastructure;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactoryResolver = new PizzaFactoryResolver();
            var pizzaFactoryTypes = pizzaFactoryResolver.GetPizzaFactoryTypes();

            foreach (var pizzaFactoryType in pizzaFactoryTypes)
            {
                var pizzaFactory = pizzaFactoryResolver.CreateInstance(pizzaFactoryType.Key);
                var pizza = pizzaFactory.CreatePizza();
                pizza.Make();
                pizza.Bake();
                pizza.Deliver();
            }

            Console.ReadKey();
        }
    }
}
