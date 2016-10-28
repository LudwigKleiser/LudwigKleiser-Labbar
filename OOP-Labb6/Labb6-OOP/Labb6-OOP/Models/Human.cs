using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP
{
   abstract class Human : INonPlayerCharacter
    {
        public string Name { get; set; }
        public abstract void Talk();
        

        public abstract string Observe();

    }
}
