using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2OOP
{
    class Lists
    {
        static List<Dog> dogs = new List<Dog>();
        static public List<Dog> Dogs { get { return dogs; } set { dogs = value; } }

        static List<Owl> owls = new List<Owl>();
        static public List<Owl>  Owls { get { return owls; } set { owls = value; } }

        static List<Snake> snakes = new List<Snake>();
        static public List<Snake> Snakes { get { return snakes; } set { snakes = value; } }

    }
}
