using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb3
{
    public class Concert : Event
    {
        
        
        public override string ShowInfo()
        {
            return String.Format("The performance by {0} costs {1}$ and will be held in {2}", Name, Price, Location);
        }
    }


}
