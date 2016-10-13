using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvPolymorfsim
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override string Introduction()
        {

            return String.Format("{0} och jag undervisar i {1}",
                base.Introduction(),
                Subject);
        }
    }
}