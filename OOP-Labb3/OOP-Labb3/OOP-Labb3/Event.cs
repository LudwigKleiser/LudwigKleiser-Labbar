using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb3
{
    public abstract class Event
    {
        public int Price { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }


        public abstract string ShowInfo();

    }
}