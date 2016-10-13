using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvPolymorfsim
{
    public class Student : Person
    {
        public string Class { get;  set; }

        public override string Introduction()
        {
            return String.Format("{0} Jag går i klassen {1}",
                base.Introduction(),
                Class);
        }
    }
}