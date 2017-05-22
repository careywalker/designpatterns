using System;
using TemplateMethod.Model.Abstract;

namespace TemplateMethod.Model.Concrete
{
    public class StuffedCrustPizza : PizzaOrder
    {
        public override void MakePizza()
        {
            Console.WriteLine("This crust is make with crust stuffed with cheese.");
        }
    }
}
