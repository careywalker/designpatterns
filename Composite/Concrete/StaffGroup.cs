using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Abstract;

namespace Composite.Concrete
{
    public class StaffGroup : IStaff
    {
        public string Name { get; set; }
        public List<IStaff> Members { get; set; }

        public StaffGroup()
        {
            Members = new List<IStaff>();
        }

        public double Tips
        {
            get
            {
                return Members.Sum(member => member.Tips);
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Tips += eachSplit + leftOver;
                    leftOver = 0.00;
                }
            }
        }

        public void Pay()
        {
            foreach (var member in Members)
            {
                member.Pay();
            }
        }
    }
}
