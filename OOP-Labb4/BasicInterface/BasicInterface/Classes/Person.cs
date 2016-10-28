using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.Classes
{
    class Person : ISpeakable
    {
        public string Speak()
        {
            return "Hello! I like turtles";
        }
    }
}
