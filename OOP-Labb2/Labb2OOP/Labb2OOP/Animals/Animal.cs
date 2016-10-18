using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public int NumberOfLegs { get; set; }
        public string Name { get; set; }

        public Animal(int age, int weight, int numberOfLegs, string name)
        {
            Age = age;
            Weight = weight;
            NumberOfLegs = numberOfLegs;
            Name = name;

        }

        public virtual string PresentAnimal()
        {
            return String.Format("{0}, is an age of {1},  weights {2} kg, has {3} legs,",
                Name,
                Age,
                Weight,
                NumberOfLegs);
        }


        public abstract string Move();


        public abstract string Talk();
        


    }
}