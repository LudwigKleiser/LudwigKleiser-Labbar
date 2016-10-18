using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public abstract class Bird : Animal
    {
        public bool CanFly { get; set; }

        public Bird(int age, int weight, int numberOfLegs, string name, bool canFly) : base(age, weight, numberOfLegs, name)
        {
            CanFly = canFly;
        }

        public override string PresentAnimal()
        {
            if(CanFly)
            {
               return String.Format("{0} it can fly,", base.PresentAnimal());
            }

            else
            {
                return String.Format("{0} it can´t fly,", base.PresentAnimal());
            }

            
        }
    }
}