using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb3
{
    public class Cinema : Event
    {
        

        public override string ShowInfo()
        {
            return String.Format("The movie {0} costs {1}$ and will be shown in {2}", Name, Price, Location);
        }
    }
}