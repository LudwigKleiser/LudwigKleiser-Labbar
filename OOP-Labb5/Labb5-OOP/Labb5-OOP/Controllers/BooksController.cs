using Labb5_OOP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_OOP
{
    class BooksController
    {
        private IRepository repository = new ListRepository();

        public void CreateBook()
        {
            var newBook = UI.CreateBook();
            repository.AddBook(newBook);
        }

        public void RemoveBook()
        {
            var books = repository.GetBooks();
            var index = UI.SelectBook(books) - 1;
            repository.RemoveBook(books[index]);
        }

        public void EditBook()
        {
            var books = repository.GetBooks();
            UI.PrintBookList(books);
            int index = UI.SelectBook(books) - 1;

            UI.EditBook(books[index]);
        }

        public void PrintBookList()
        {
            Console.Clear();
            UI.PrintBookList(repository.GetBooks());
            Console.ReadKey(true);
        }
    }
}
