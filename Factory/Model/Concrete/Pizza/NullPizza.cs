using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Model.Abstract;

namespace Factory.Model.Concrete.Pizza
{
    public class NullPizza : IPizza
    {
        public void Make()
        {
            Console.WriteLine($"{GetType().Name} cannot be made.");
        }

        public void Bake()
        {
            Console.WriteLine($"{GetType().Name} cannot be cooked.");
        }

        public void Deliver()
        {
            Console.WriteLine($"{GetType().Name} cannot be delivered");
        }
    }
}
