using OOP_Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb13.Managers
{
    class ItemManager
    {
        public List<Item> ItemList { get; set; }

        public ItemManager()
        {
            ItemList = new List<Item>
            {
                new Item { Name = "Korv", Age = 4, Worth = 20 },
                new Item { Name = "Banan", Age = 1, Worth = 10 },
                new Item { Name = "Mjölk", Age = 8, Worth = 12 },
                new Item { Name = "Tacokrydda", Age = 11, Worth = 15 },
                new Item { Name = "Stroganoff", Age = 5, Worth = 42 },
                new Item { Name = "Blodpudding", Age = 9, Worth = 19 },
                new Item { Name = "Palt", Age = 19, Worth = 24 },
                new Item { Name = "Krydaa", Age = 7, Worth = 16 }

            };
        }

        internal void ShowAllProducts()
        {
            
            foreach (var product in ItemList)
            {
                Console.WriteLine("{0} -- {1} days -- {2}SEK", product.Name, product.Age, product.Worth);
            }

        }

        public void PrintWhere(ItemFilter filter)
        {
            foreach (var item in ItemList)
            {
                if(filter(item))
                    Console.WriteLine("{0} -- {1} days -- {2}SEK", item.Name, item.Age, item.Worth);
            }
        }

        internal void AddNewProduct(Runtime runtime)
        {
            Console.Write("Product name: ");
            string newName = Console.ReadLine();
            Console.Write("Product age: ");
            int newAge = 0;
            bool isAge = false;
            while (!isAge)
            {
                string input = Console.ReadLine();
                isAge = int.TryParse(input, out newAge);
                if (!isAge) runtime.OnWrongInput("Please enter a valid age");
            }


            Console.Write("Product worth: ");
            int newWorth = 0;
            bool isWorth = false;
            while (!isWorth)
            {
                string input = Console.ReadLine();
                isWorth = int.TryParse(input, out newWorth);
                if (!isWorth) runtime.OnWrongInput("Please enter a valid worth");
            }

            ItemList.Add(new Item { Name = newName, Age = newAge, Worth = newWorth });
        }
            
        }

        
    }

