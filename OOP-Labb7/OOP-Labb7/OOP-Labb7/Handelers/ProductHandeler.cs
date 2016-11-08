using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb7
{
    class ProductHandeler
    {

        public static void ShowSpecificProduct(string type)
        {
            Console.Clear();
            var specificProduct = from product in MyLists.products
                           where product.Type == type
                           select product;
            foreach (var product in specificProduct)
            {
                product.Description();
            }
            Console.ReadKey(true);
        }

        public static void ShowAllProducts()
        {
            var sortedProducts = MyLists.products.OrderBy(x => x.Type).ToList();

            foreach (var product in sortedProducts)
            {
                product.Description();
            }
            Console.ReadKey(true);
            
        }

        public static void AddProduct(string type)
        {
            Console.Clear();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Clear();

            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            if (type == "Food") MyLists.products.Add(new Food(name, brand, price, type));
            else if (type == "Medicine") MyLists.products.Add(new Medicine(name, brand, price, type));
            else MyLists.products.Add(new Electronics(name, brand, price, type));

        }

        

    }
}
