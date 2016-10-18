using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public class Dog : Mammal
    {
        public bool FluffyTail { get; set; }
        

        public Dog(int age, int weight, int numberOfLegs, string name, bool canSwim, bool fluffyTail) : base(age, weight, numberOfLegs, name, canSwim)
        {
            FluffyTail = fluffyTail;
        }

        public override string PresentAnimal()
        {
            if(FluffyTail)
            { 
            return String.Format("The dog {0} and has a fluffy tail.",
                base.PresentAnimal(), FluffyTail);
            }
            else
            {
                return String.Format("The dog {0} and does not have a fluffy tail.",
                    base.PresentAnimal(), FluffyTail);
            }
            
        }

        public override string Move()
        {
            return String.Format("The dog uses it´s {0} legs to run", NumberOfLegs);
        }

        public override string Talk()
        {
            return String.Format("Woof Woof");
        }
    }
}