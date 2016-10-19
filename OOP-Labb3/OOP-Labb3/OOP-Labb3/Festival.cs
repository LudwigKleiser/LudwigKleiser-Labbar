using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb3
{
    public class Festival : Event
    {

        

        public override string ShowInfo()
        {
            return String.Format("The festival {0} costs {1}$ and is located in {2}", Name, Price, Location);
        }
    }
}