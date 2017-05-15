using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Abstract
{
    public interface IStaff
    {
        double Tips { get; set; }
        void Pay();
    }
}
