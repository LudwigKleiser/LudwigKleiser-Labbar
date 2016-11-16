using OOP_Labb10.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb10
{
    class Runtime
    {

        public void Start()
        {
            BookManager manager = new BookManager();
            BookFilter isNovel = BookFilters.IsNovel;
            BookFilter isShortStory = BookFilters.IsShortStory;
            BookFilter isGenreMystery = BookFilters.IsGenreMystery;
            BookFilter isGenreAction = BookFilters.IsGenreAction;
            BookFilter isGenreRomance= BookFilters.IsGenreRomance;
            BookFilter isCheap= BookFilters.IsCheap;
            BookFilter isExpensive= BookFilters.IsExpensive;

            bool start = true;
            while (start)
            {
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("1. Is a novel:");
                Console.WriteLine("2. Is a short story:");
                Console.WriteLine("3. Genre mystery:");
                Console.WriteLine("4. Genre action:");
                Console.WriteLine("5. Genre romance:");
                Console.WriteLine("6. Is cheap:");
                Console.WriteLine("7. Is expensive:");
                Console.WriteLine("8. Quit");

                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        manager.PrintWhere(isNovel);
                        
                        break;

                    case ConsoleKey.D2:
                        manager.PrintWhere(isShortStory);
                        break;

                    case ConsoleKey.D3:
                        manager.PrintWhere(isGenreMystery);
                        break;
                    case ConsoleKey.D4:
                        manager.PrintWhere(isGenreAction);
                        break;
                    case ConsoleKey.D5:
                        manager.PrintWhere(isGenreRomance);
                        break;
                    case ConsoleKey.D6:
                        manager.PrintWhere(isCheap);
                        break;
                    case ConsoleKey.D7:
                        manager.PrintWhere(isExpensive);
                        break;
                    case ConsoleKey.D8:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Nej");
                        break;

                }


            }

        }
    }
}
