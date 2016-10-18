using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2OOP
{
    public abstract class Reptile : Animal
    {
        public int ShredSkinAYear { get; set; }


        public Reptile(int age, int weight, int numberOfLegs, string name, int shredSkinAYear) : base(age, weight, numberOfLegs, name)
        {
            ShredSkinAYear = shredSkinAYear;
        }
    }
}