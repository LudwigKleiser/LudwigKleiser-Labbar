using OOP_Labb12.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb12
{
    class Runtime
    {
       
        
        public void Start()
        {
            MovieManager manager = new MovieManager();
            bool start = true;
            while (start)
            {
                Console.Clear();
                Console.WriteLine("1. Search by Title");
                Console.WriteLine("2. Get movies from genre");
                Console.WriteLine("3. Get movies under 120 min");
                Console.WriteLine("4. Create array of all movie names");
                Console.WriteLine("5. Save name in string");
                Console.WriteLine("6. Get all movies that begin with T, specific genre, longer than 120 min");
                Console.WriteLine("7. Quit");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.SearchNameOrGenre(true);
                        break;

                    case ConsoleKey.D2:
                        manager.SearchNameOrGenre(false);
                        break;

                    case ConsoleKey.D3:
                        manager.ShorterThanOneHundredAndTwentyMinutesLong();
                        break;

                    case ConsoleKey.D4:
                        manager.CreateStringArray();
                        break;

                    case ConsoleKey.D5:
                        manager.SpecificMovieToString();
                        break;

                    case ConsoleKey.D6:
                        manager.StartingWithSpecificGenreLongerThanOneHundredTwentyMinutesLong();
                        break;

                    case ConsoleKey.D7:
                        start = false;
                        break;

                    default:

                        break;
                }
            }
        }
    }
}
