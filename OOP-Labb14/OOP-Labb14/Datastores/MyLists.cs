using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb14.Datastores
{
    class MyLists
    {
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Paper> Papers { get; set; }
        public List<Author> Authors { get; set; }

        public MyLists()
        {
            Authors = new List<Author>
            {
            new Author { Name = "Nisse", Age = 25 },
            new Author { Name = "Johan", Age = 80 },
            new Author { Name = "Ludwig", Age = 23 }
        };

             

            Books = new List<Book>
            {
                new Book { Author = Authors[0],
                    Pages = 250,
                    Title = "Game of Thrones",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2008, 3, 9)},

                new Book { Author = Authors[1],
                    Pages = 1000,
                    Title = "Harry Potter",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2005, 4, 12)},

                new Book { Author = Authors[2],
                    Pages = 450,
                    Title = "The Hunt for Red October",
                    Genre = "Action",
                    ReleaseDate = new DateTime(1999, 3, 9)},
            };

            Magazines = new List<Magazine>
            {
                new Magazine { Author = Authors[0],
                    Title = "Fib Aktuellt",
                    ReleaseDate = new DateTime(2005, 11, 16) },

                new Magazine { Author = Authors[1],
                    Title = "Akutell Rapport",
                    ReleaseDate = new DateTime(1998, 6, 16) },

                new Magazine { Author = Authors[2],
                    Title = "PC gamer",
                    ReleaseDate = new DateTime(1888, 7, 16) }

            };

            Papers = new List<Paper>
            {
                new Paper { Author = Authors[0],
                    Title = "Aftonbladet",
                    ReleaseDate = new DateTime(2016, 11, 16) },

                new Paper { Author = Authors[1],
                    Title = "Svenska dagbladet",
                    ReleaseDate = new DateTime(2016, 12, 16) },

                new Paper { Author = Authors[2],
                    Title = "Expressen",
                    ReleaseDate = new DateTime(2016, 6, 16) },

            };
        }
    }
}
