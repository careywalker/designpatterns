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
            largePizza = new CheeseDecorator(largePizza);
            largePizza = new JalapenoDecorator(largePizza);
            largePizza = new PepperoniDecorator(largePizza);


            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
