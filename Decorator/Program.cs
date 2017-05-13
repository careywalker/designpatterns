using System;
using Decorator.Model.Abstract;
using Decorator.Model.Concrete;
using Decorator.Model.ConcreteDecorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Jalapeno(largePizza);
            largePizza = new Pepperoni(largePizza);


            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
