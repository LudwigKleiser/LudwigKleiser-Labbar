using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public class Snake : Reptile
    {
        public bool SplitTongue { get; set; } 
        

        public Snake(int age, int weight, int numberOfLegs, string name, int shredSkinAYear, bool splitTongue) : base(age, weight, numberOfLegs, name, shredSkinAYear)
        {
            SplitTongue = splitTongue;
        }

        public override string PresentAnimal()
        {
            if(SplitTongue)
            { 
            return String.Format("The snake {0} it shreds {1} times a year and has a split tongue",
                base.PresentAnimal(), ShredSkinAYear);
            }
            else
            {
                return String.Format("The snake {0} it shreds {1} times a year and does not have a split tongue.",
                    base.PresentAnimal(), ShredSkinAYear);
            }
        }

        public override string Move()
        {
            return String.Format("The snake rattles as it creeps along");
        }

        public override string Talk()
        {
            return String.Format("Shhhhhhh");
        }
    }
}