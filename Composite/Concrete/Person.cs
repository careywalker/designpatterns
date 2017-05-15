using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Abstract;

namespace Composite.Concrete
{
    public class Person : IStaff
    {
        public string Name { get; set; }
        public double Tips { get; set; }

        public void Pay()
        {
            Console.WriteLine($"{Name} is owed : {Tips} in tips for the night.");
        }
    }
}
