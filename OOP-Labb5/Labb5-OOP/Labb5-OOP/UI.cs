using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    class UI
    {
        public static void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Books");
            Console.WriteLine("2. Games");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Quit");
        }

        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Show all");
            Console.WriteLine("5. Return");

        }

        

        public static Game CreateGame()
        {
            Game newGame = new Game();
            Console.Clear();
            Console.Write("Game name: ");
            newGame.Name = Console.ReadLine();
            bool gameLoop = true;
            while(gameLoop)
            { 
            Console.WriteLine("Game genres:");
            PrintGameGenres();
            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
                if (choice > 5|| choice < 1)
                {
                    Console.WriteLine("You did not enter a valid command, press any key to try again");
                    Console.ReadKey(true);
                }

                else
                {
                    newGame.Genre = (Game.GenreType)choice;
                    gameLoop = false;
                }
            }

            return newGame;
        }

        public static void EditGame(Game game)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Game: {0}. Genre: {1}", game.Name, game.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    game.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre list:");
                    PrintGameGenres();
                    Console.Write("New genre: ");
                    game.Genre = (Game.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static int SelectGame(Game[] games)
        {
            
            while(true)
            { 
            PrintGameList(games);
            Console.Write("Select game: ");
            int selectGame = int.Parse(Console.ReadLine());
                if (selectGame > MyLists.Games.Count || selectGame < 1)
                {
                    Console.WriteLine("You did not enter a valid command, press any key to try again");
                    Console.ReadKey(true);
                }

                else return selectGame;





            }
        }

        public static void PrintGameGenres()
        {
            Console.Clear();
            foreach (var genre in Enum.GetValues(typeof(Game.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintGameList(Game[] games)
        {
            Console.Clear();
            foreach (var game in games)
            {
                Console.WriteLine("{0}. Game: {1}, Genre: {2}",
                    Array.IndexOf(games, game) + 1,
                    game.Name,
                    game.Genre);
            }
        }

        

        public static Book CreateBook()
        {
            Book newBook = new Book();
            Console.Clear();
            Console.Write("Book Author: ");
            newBook.Author = Console.ReadLine();

            Console.Write("Book Name: ");
            newBook.Name = Console.ReadLine();

            Console.WriteLine("Book genres:");
            PrintBookGenres();
            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
            newBook.Genre = (Book.GenreType)choice;

            return newBook;
        }

        public static void EditBook(Book book)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.WriteLine("3. Change author");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Author: {0}.Book: {1}. Genre: {2}",book.Author, book.Name, book.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    book.Name = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Genre list:");
                    PrintBookGenres();
                    Console.Write("New genre: ");
                    book.Genre = (Book.GenreType)int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    Console.Write("New author: ");
                    book.Author = Console.ReadLine();
                    break;

            }
        }

        public static int SelectBook(Book[] books)
        {
            while(true)
            {
            PrintBookList(books);
            Console.Write("Select game: ");
                int selectBook = int.Parse(Console.ReadLine());
                if(selectBook > MyLists.Books.Count || selectBook < 1)
                {
                    Console.WriteLine("You did not enter a valid command, press any key to try again");
                    Console.ReadKey(true);
                }
                else return selectBook;



            }
        }

        public static void PrintBookGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Book.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintBookList(Book[] books)
        {
            Console.Clear();
            foreach (var book in books)
            {
                Console.WriteLine("{0}. Author: {1}, Book: {2}, Genre: {3}",
                    Array.IndexOf(books, book) + 1,
                    book.Author,
                    book.Name,
                    book.Genre);
            }
        }
    }
}
