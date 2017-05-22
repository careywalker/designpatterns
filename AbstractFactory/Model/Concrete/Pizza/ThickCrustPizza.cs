using System;
using Factory.Model.Abstract;

namespace Factory.Model.Concrete.Pizza
{
    internal class ThickCrustPizza : IPizza
    {
        public void Make()
        {
            Console.WriteLine($"{GetType().Name} is being made.");
        }

        public void Bake()
        {
            Console.WriteLine($"{GetType().Name} is baking.");
        }

        public void Deliver()
        {
            Console.WriteLine($"{GetType().Name} has been delivered.");
        }
    }
}
