using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb13
{
    class UserMenus
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to waretracker.");
            Console.WriteLine("---");
            Console.WriteLine("1. Show products");
            Console.WriteLine("2. Add products");
            Console.WriteLine("3. Quit");
            Console.WriteLine("---");
        }

        public static void FilterMenu()
        {
            Console.WriteLine("1. Cheap products");
            Console.WriteLine("2. Old products");
            Console.WriteLine("3. Fresh products");            
            Console.WriteLine("4. Return");
        }
    }
}
