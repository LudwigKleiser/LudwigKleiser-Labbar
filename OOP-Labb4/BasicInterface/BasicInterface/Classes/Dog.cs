using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.Classes
{
    class Dog : ISpeakable
    {
        public string Speak()
        {
            return "Woof Woof";
        }
    }
}
