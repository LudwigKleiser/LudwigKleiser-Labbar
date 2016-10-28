using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Labb5_OOP
{
    class MyLists
    {
        private static List<Game> games;
        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;
            }
        }

        private static List<Book> books;
        public static List<Book> Books
        {
            get
            {
                if (books == null)
                    books = new List<Book>();

                return books;
            }
        }

        public static void SaveToDisk() 
        {
            string[] saveBookToFile = new string[Books.Count * 3];
            for (int i = 0; i < Books.Count; i++)
            {
                saveBookToFile[i * 3] = Books[i].Author;
                saveBookToFile[i * 3 + 1] = Books[i].Name;
                saveBookToFile[i * 3 + 2] = ((int)Books[i].Genre).ToString();
                
            }

            File.WriteAllLines(@"C:\Users\public\Books.txt", saveBookToFile);

            string[] saveGameToFile = new string[Games.Count * 2];
            for (int i = 0; i < Games.Count; i++)
            {
                saveGameToFile[i * 3] = Games[i].Name;
                saveGameToFile[i * 3 + 1] = ((int)Games[i].Genre).ToString();

            }

            File.WriteAllLines(@"C:\Users\public\Games.txt", saveGameToFile);
        }

        public static void ListApplier()
        {

            string[] readFromBookFile;
            try
            {
                readFromBookFile = File.ReadAllLines(@"C:\Users\public\Books.txt");
            }
            catch (FileNotFoundException)
            {
                File.Create(@"C:\Users\public\Books.txt").Dispose();
                readFromBookFile = File.ReadAllLines(@"C:\Users\public\Books.txt");

            }

            for (int i = 0; i < readFromBookFile.Length; i += 3)
            {
                Books.Add(new Book
                {
                    Author = readFromBookFile[i],
                    Name = readFromBookFile[i + 1],
                    Genre = (Book.GenreType)int.Parse(readFromBookFile[i + 2])
                });
            }

            string[] readFromGameFile;
            try
            {
                readFromGameFile = File.ReadAllLines(@"C:\Users\public\Games.txt");
            }
            catch (FileNotFoundException)
            {
                File.Create(@"C:\Users\public\Games.txt").Dispose();
                readFromGameFile = File.ReadAllLines(@"C:\Users\public\Games.txt");

            }

            for (int i = 0; i < readFromGameFile.Length; i += 2)
            {
                Games.Add(new Game
                {
                    
                    Name = readFromGameFile[i],
                    Genre = (Game.GenreType)int.Parse(readFromGameFile[i + 1])
                });
            }




        }
    }
}
