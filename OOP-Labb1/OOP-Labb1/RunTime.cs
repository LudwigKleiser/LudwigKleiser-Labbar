using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb1
{
    class RunTime
    {
        public void Start()
        {
            Dog d1 = new Dog("Ludde", 5, "Bulldog");
            Dog d2 = new Dog("Dutten", 2, "Tax");
            Dog d3 = new Dog("Plutten", 7, "Pug");

            Console.WriteLine(d1.Name + " " + d1.Age+ " " + d1.Breed);
            Console.WriteLine(d2.Name + " " + d2.Age + " " + d2.Breed);
            Console.WriteLine(d3.Name + " " + d3.Age + " " + d3.Breed);

        }
    }
}
