using OOP_Labb12.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb12.Manager
{
    class MovieManager
    {
        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>
            {
                new Movie {Title = "The Hunt for Red October", Genre = "Action", Lenght = 86 },
                new Movie {Title = "The Schindlers List", Genre = "Action", Lenght = 195 },
                new Movie {Title = "Fäbodajäntan", Genre = "Porr", Lenght = 116 },
                new Movie {Title = "Die Hard", Genre = "Action", Lenght = 131 },
                new Movie {Title = "The Sum of All Fears", Genre = "Action", Lenght = 124},
                new Movie {Title = "Ridskolan", Genre = "Porr", Lenght = 73 },
            };

        }
        internal void SearchNameOrGenre(bool titleOrGenre)
        {
            var searchResult = Movies.Where(title => title.Title == "");

            if (titleOrGenre)
            {
                Console.Write("Search for Title: ");
                var input = Console.ReadLine();

                searchResult = Movies.Where(title => title.Title == input);
            }

            else
            {
                Console.Write("Search for Genre: ");
                var input = Console.ReadLine();

                searchResult = Movies.Where(genre => genre.Genre == input);

            }

            foreach (var movie in searchResult)
            {
                Console.WriteLine("Title: {0}, Genre: {1} Lenght:{2}(M)", movie.Title, movie.Genre, movie.Lenght);
            }
            Console.ReadLine();
        
        
            
        }

        

        internal void ShorterThanOneHundredAndTwentyMinutesLong()
        {
            
            

            var searchResult = Movies.Where(title => title.Lenght < 120);
            foreach (var movie in searchResult)
            {
                Console.WriteLine("Title: {0}, Genre: {1} Lenght:{2}(M)", movie.Title, movie.Genre, movie.Lenght);
            }
            Console.ReadKey(true);
        }

        internal void CreateStringArray()
        {
            var orderTitles= Movies.OrderBy(x => x.Title).ToArray();
            int i = 0;
            string[] arrayOfTitles = new string[orderTitles.Length];
            foreach (var title in orderTitles)
            {
                arrayOfTitles[i] = orderTitles[i].Title;
                i++;
            }

            for (int o = 0; o < arrayOfTitles.Length; o++)
            {
                Console.WriteLine(arrayOfTitles[o]);
            }
            Console.ReadKey();
        }

        internal void SpecificMovieToString()
        {
            Console.Write("Search for title: ");
            var input = Console.ReadLine();
            var searchResults = Movies.Where(movie => movie.Title == input);
            string savedMovie = "";

            foreach (var title in searchResults)
            {
                savedMovie = title.Title;
            }

           

            Console.WriteLine("Saved {0} to a string",savedMovie);
            Console.ReadLine();
        }

        internal void StartingWithSpecificGenreLongerThanOneHundredTwentyMinutesLong()
        {
            Console.Write("Search for genre: ");
            var input = Console.ReadLine();

            var searchResult = Movies.Where(movie =>
            movie.Genre == input 
            && movie.Title[0] == 'T'            
            && movie.Lenght > 120);

            foreach (var movie in searchResult)
            {
                Console.WriteLine("Title: {0} Genre: {1} Lenght:{2}(M)", movie.Title, movie.Genre, movie.Lenght);
            }
            Console.ReadLine();

        }
    }
}
