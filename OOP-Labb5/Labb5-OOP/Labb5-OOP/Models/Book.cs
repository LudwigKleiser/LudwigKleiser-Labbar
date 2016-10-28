using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    class Book
    {
        public enum GenreType
        {
            Fantasy = 1,
            Horror,
            Thriller,
            Autobiography

        }
        public string Author { get; set; }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
