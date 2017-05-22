using System;
using TemplateMethod.Model.Concrete;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var thinCrustPizza = new ThinCrustPizza();
            thinCrustPizza.ProcessOrder();

            var thickCrustPizza = new ThickCrustPizza();
            thickCrustPizza.ProcessOrder();

            var stuffedCrustPizza = new StuffedCrustPizza();
            stuffedCrustPizza.ProcessOrder();

            Console.ReadKey();
        }
    }
}
