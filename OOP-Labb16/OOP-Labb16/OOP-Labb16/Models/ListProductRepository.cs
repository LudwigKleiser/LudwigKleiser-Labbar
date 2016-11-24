using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb16.Models
{
    class ListProductRepository : IProductRepository
    {
        List<Product> Products { get; set; }

        public ListProductRepository()
        {
            Products = new List<Product>
            {
                new Product { Price = 25, Name = "TV", ID = 1 },
                new Product { Price = 48, Name = "Food", ID = 2 }
            };
        }

        public void Add()
        {
            Console.Write("Name: ");
            string newName = Console.ReadLine();
            Console.Clear();

            Console.Write("Price:  ");
            int newPrice = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("ID");
            int newID = int.Parse(Console.ReadLine());

            Products.Add(new Product { Name = newName, Price = newPrice, ID = newID });

            Console.WriteLine("Added! Press any key to continue.");
            Console.ReadKey(true);

        }

        public void Delete(int id)
        {
            Products.Remove(Products.SingleOrDefault(product => product.ID == id));
            Console.WriteLine("Removing....");
            Console.ReadKey(true);
        }

        public void Get(int id)
        {
            var specificProduct = Products.Where(product => product.ID == id).ToList();
            var updatedProduct = new Product();
            foreach (var product in specificProduct)
            {
                updatedProduct.ID = product.ID;
                updatedProduct.Name = product.Name;
                updatedProduct.Price = product.Price;
            }
            Update(updatedProduct);
            specificProduct.ForEach(PrintSingle);
            Console.ReadKey(true);
        }

        public void GetAll()
        {
            Products.ForEach(PrintSingle);
            
        }

        public void DecideOnDelete()
        {
            GetAll();
            Console.Write("Enter the ID of the product you wish to delete: ");
            int id = int.Parse(Console.ReadLine());

            Delete(id);
        }

        public void DecideOnProduct()
        {
            Products.ForEach(product => Console.WriteLine("{0}--ID: {1}", product.Name, product.ID));
            Console.Write("Enter the ID of the product you wish to get: ");
            int id = int.Parse(Console.ReadLine());

            Get(id);
        }


        public void Update(Product updatedProduct)
        {
            Products.Add(updatedProduct);
        }

        public void PrintSingle(Product product)
        {
            Console.WriteLine("{0}-- Price:{1}($) -- Id:{2}", product.Name, product.Name, product.ID);
        }
    }
}


