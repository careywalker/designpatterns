using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Model.Concrete;

namespace Template
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
