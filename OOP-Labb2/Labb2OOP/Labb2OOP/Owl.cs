using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public class Owl : Bird
    {
        public int NumberOfFeathers { get; set; }
        

        public Owl(int age, int weight, int numberOfLegs, string name, bool canFly, int numberOfFeathers) : base(age, weight, numberOfLegs, name, canFly)
        {
            NumberOfFeathers = numberOfFeathers;
        }

        public override string PresentAnimal()
        {
            return String.Format("The Owl {0} it has {1} feathers.", base.PresentAnimal(), NumberOfFeathers);
        }

        public override string Move()
        {
            return String.Format("The owl soars across the sky");
        }

        public override string Talk()
        {
            return String.Format("oooouUuuuo");
        }
    }
}