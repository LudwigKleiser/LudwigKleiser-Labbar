using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    class Client
    {
        public void Start()
        {
            MyLists.ListApplier();
            bool loop = true;

            while (loop)
            {
                UI.PrintStartMenu();
                var choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        BookChoice();
                        break;

                    case ConsoleKey.D2:
                        GameChoice();
                        break;

                    case ConsoleKey.D3:
                        MyLists.SaveToDisk();
                        break;

                    case ConsoleKey.D4:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("You did not enter a valid command, press any key to try again");
                        Console.ReadKey(true);

                        break;
                }
            }
        }

        public void BookChoice()
        {
            var books = new BooksController();
            bool loop = true;
            while (loop)
            {
                UI.PrintMainMenu();
                var choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        books.CreateBook();
                        break;

                    case ConsoleKey.D2:
                        books.RemoveBook();
                        break;

                    case ConsoleKey.D3:
                        books.EditBook();
                        break;

                    case ConsoleKey.D4:
                        books.PrintBookList();
                        break;

                    case ConsoleKey.D5:
                        loop = false;

                        break;

                    default:
                        Console.WriteLine("You did not enter a valid command, press any key to try again");
                        Console.ReadKey(true);

                        break;
                }
            }
        }

        public void GameChoice()
        {
            var games = new GamesController();

            bool loop = true;
            while (loop)
            {

                UI.PrintMainMenu();
                var choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        games.CreateGame();
                        break;

                    case ConsoleKey.D2:
                        games.RemoveGame();
                        break;

                    case ConsoleKey.D3:
                        games.EditGame();
                        break;

                    case ConsoleKey.D4:
                        games.PrintGameList();
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("You did not enter a valid command, press any key to try again");
                        Console.ReadKey(true);

                        break;
                }

            }
        }
    }
}
