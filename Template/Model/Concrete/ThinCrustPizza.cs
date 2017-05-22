using System;
using TemplateMethod.Model.Abstract;

namespace TemplateMethod.Model.Concrete
{
    public class ThinCrustPizza : PizzaOrder
    {
        public override void MakePizza()
        {
            Console.WriteLine("This pizza is made with a thin crust.");
        }
    }
}
