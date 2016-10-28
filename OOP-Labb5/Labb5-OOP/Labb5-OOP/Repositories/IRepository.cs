using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP.Controllers
{
    interface IRepository
    {
        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);

        Book[] GetBooks();
        void AddBook(Book newBook);
        void RemoveBook(Book book);
    }
}
