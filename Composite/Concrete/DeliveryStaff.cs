using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Abstract;

namespace Composite.Concrete
{
    public class DeliveryStaff : IStaff
    {
        public Person Person { get; set; }

        public double Tips
        {
            get { return Person.Tips; }
            set { Person.Tips = value; }
        }

        public void Pay()
        {
            Person.Pay();
        }
    }
}
