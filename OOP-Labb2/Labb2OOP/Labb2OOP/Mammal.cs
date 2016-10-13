using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public abstract class Mammal : Animal
    {
        public bool CanSwim { get; set; }

        public Mammal(int age, int weight, int numberOfLegs, string name, bool canSwim) : base(age, weight, numberOfLegs, name)
        {
            CanSwim = canSwim;
        }

        public override string PresentAnimal()
        {
            if (CanSwim)
            {
                return String.Format("{0} it can swim,", base.PresentAnimal());
            }

            else
            {
                return String.Format("{0} it can´t swim,", base.PresentAnimal());
            }

        }
    }
}