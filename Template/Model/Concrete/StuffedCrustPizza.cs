using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Model.Abstract;

namespace Template.Model.Concrete
{
    public class StuffedCrustPizza : PizzaOrder
    {
        public override void MakePizza()
        {
            Console.WriteLine("This crust is make with crust stuffed with cheese.");
        }
    }
}
