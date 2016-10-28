using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP.Controllers
{
    class ListRepository : IRepository
    {
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }

        public Book[] GetBooks()
        {
            return MyLists.Books.ToArray();
        }

        public void AddBook(Book newBook)
        {
            MyLists.Books.Add(newBook);
        }
        public void RemoveBook(Book book)
        {
            MyLists.Books.Remove(book);
        }

       
    }
}
