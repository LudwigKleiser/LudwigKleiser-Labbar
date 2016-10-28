using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP
{
    class Room : IEnvironment
    {
        public string Description { get; set; }
        public string DescriptionObservation { get; set; }
        public int Position { get; set; }
        List<INonPlayerCharacter> nonPlayerCharacter;
        public List<INonPlayerCharacter> NonPlayerCharacter
        {
            get
            {
                if (nonPlayerCharacter == null) nonPlayerCharacter = new List<INonPlayerCharacter>();
                return nonPlayerCharacter;
            }
        }

        public void Observe()
        {
            Console.WriteLine(DescriptionObservation);
        }

        public Room(int position, string description, string descriptionObservation)
        {
            Position = position;
            Description = description;
            DescriptionObservation = descriptionObservation;
        }
    }
}
