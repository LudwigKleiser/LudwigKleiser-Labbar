using OOP_Labb14.Datastores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb14
{
    class Runtime
    {
        public void Start()
        {
            var lists = new MyLists();
            while(true)
            {
                Console.WriteLine("Seach for an author to see his work");
                string input = Console.ReadLine();

                var searchResultInBooks = lists.Books.Where(author => author.Author.Name == input);
                var searchResultInPapers = lists.Papers.Where(author => author.Author.Name == input);
                var searchResultInMagazines = lists.Magazines.Where(author => author.Author.Name == input);

                if (!searchResultInBooks.Any())
                    Console.WriteLine("No result for {0} in books", input);

                foreach (var item in searchResultInBooks)
                {
                    Console.WriteLine("Author: {0}, Age: {1}, Title: {2}, Genre: {3}, Pages: {4}, Realease date: {5:yyyy/MM/d}",
                        item.Author.Name,
                        item.Author.Age,
                        item.Title,
                        item.Genre,
                        item.Pages,
                        item.ReleaseDate);
                }

                if (!searchResultInPapers.Any())
                    Console.WriteLine("No result for {0} in papers", input);

                foreach (var item in searchResultInPapers)
                {
                    Console.WriteLine("Author: {0}, Age: {1}, Title: {2}, Realease date: {3:yyyy/MM/d}",
                        item.Author.Name,
                        item.Author.Age,
                        item.Title,
                        item.ReleaseDate);
                }

                if (!searchResultInMagazines.Any())
                    Console.WriteLine("No result for {0} in magazines", input);

                foreach (var item in searchResultInMagazines)
                {
                    Console.WriteLine("Author: {0}, Age: {1}, Title: {2}, Realease date: {3:yyyy/MM/d}",
                       item.Author.Name,
                       item.Author.Age,
                       item.Title,
                       item.ReleaseDate);
                }
            }
            
        }
    }
}
