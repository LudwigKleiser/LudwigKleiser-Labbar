using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb7
{
    class GUI
    {


        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add products");
            Console.WriteLine("2. Remove products");
            Console.WriteLine("3. Show products");
            Console.WriteLine("4. Quit");
        }

        public static void DecideOnProductMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Medicine");
            Console.WriteLine("3. Electronics");
            Console.WriteLine("4. Return");
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                    ProductHandeler.AddProduct("Food");
                    break;

                case ConsoleKey.D2:
                    ProductHandeler.AddProduct("Medicine");
                    break;

                case ConsoleKey.D3:
                    ProductHandeler.AddProduct("Electronics");
                    break;

                case ConsoleKey.D4:

                    break;

                default:

                    break;


            }
        }

        public static void ShowProductsMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Medicine");
            Console.WriteLine("3. Electronics");
            Console.WriteLine("4. Show all");          
            Console.WriteLine("5. Return");
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.D1:
                    ProductHandeler.ShowSpecificProduct("Food");
                    
                    break;

                case ConsoleKey.D2:
                    ProductHandeler.ShowSpecificProduct("Medicine");
                    break;

                case ConsoleKey.D3:
                    ProductHandeler.ShowSpecificProduct("Electronics");

                    break;

                case ConsoleKey.D4:
                    ProductHandeler.ShowAllProducts();
                    break;

                case ConsoleKey.D5:

                    break;

                
                default:

                    break;
            }


        }

        public static void ProductRemoveMenu()
        {
            int i = 1;
            foreach (var product in MyLists.products)   
            {
                Console.WriteLine("({0}) Type: {1}. Name: {2}. Brand: {3}. Price:{4}$"
                    ,i, product.Type, product.ProductName, product.Brand, product.Price);
                     i++;
            }
            Console.Write("Remove: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            MyLists.products.RemoveAt(choice);
            Console.Clear();
            Console.WriteLine("Removing....");
            Console.ReadKey();
            
        }

        
    }
}
