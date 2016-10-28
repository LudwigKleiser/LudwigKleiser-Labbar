using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.Classes
{
    // The class that implements the interface defnines _how_ things are done,
    // how they look, behave etc. In other words; this is where we fill the
    // methods with code
    class Bird : IFlyable, ISpeakable

    {

        public string Color { get; set; }
        public int TopSpeed { get; set; }


        public void Fly()
        {
            Console.WriteLine("Flap flap");
        }

        public string Speak()
        {
            return "Tweet tweet";
        }
    }
}
