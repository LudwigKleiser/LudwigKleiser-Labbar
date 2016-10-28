using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP
{
    class Yard : IEnvironment
    {
       
        List<INonPlayerCharacter> nonPlayerCharacter;
        public List<INonPlayerCharacter> NonPlayerCharacter
        {
            get
            {
                if (nonPlayerCharacter == null) nonPlayerCharacter = new List<INonPlayerCharacter>();
                return nonPlayerCharacter;
            }
        }

        public string Description { get; set; }
        public string DescriptionObservation { get; set; }
        public int Position { get; set; }

        public void Observe()
        {
            Console.WriteLine(DescriptionObservation);
        }
        public Yard(int position, string description, string descriptionObservation)
        {
            Position = position;
            Description = description;
            DescriptionObservation = descriptionObservation;
        }
    }
}
