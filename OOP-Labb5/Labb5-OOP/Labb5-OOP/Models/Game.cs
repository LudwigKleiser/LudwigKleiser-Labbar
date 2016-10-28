using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    class Game
    {
        public enum GenreType
        {
            FPS = 1,
            MMORPG,
            RPG,
            Fighting,
            Strategy

        }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
