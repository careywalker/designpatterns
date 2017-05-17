using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Model.Abstract;

namespace Factory.Model.Concrete.Pizza
{
    public class ThinCrustPizza : IPizza
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
