using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model.Abstract
{
    public interface IPizza
    {
        void Make();
        void Bake();
        void Deliver();
    }
}
