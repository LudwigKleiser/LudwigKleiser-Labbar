using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb7
{
    class Client
    {
        public void Start()
        {
            SomeHelp();
            bool loop = true;
            while(loop)
            {
                GUI.StartMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        GUI.DecideOnProductMenu();
                        break;

                    case ConsoleKey.D2:
                        GUI.ProductRemoveMenu();
                        break;

                    case ConsoleKey.D3:
                        GUI.ShowProductsMenu();

                        break;

                    case ConsoleKey.D4:
                        loop = false;
                        break;

                    default:

                        break;
                }
            }
        }

        public static void SomeHelp()
        {
           MyLists.products.Add(new Food("Banana", "Chiquita", 10, "Food"));
           MyLists.products.Add(new Food("Apple", "Chiquita", 12, "Food"));
           MyLists.products.Add(new Medicine("Alvedon", "Astra", 25, "Medicine"));
           MyLists.products.Add(new Medicine("Alvedon1", "Astra1", 255, "Medicine"));
           MyLists.products.Add(new Electronics("Spis", "Test", 250, "Electronics"));
           MyLists.products.Add(new Electronics("Spis1", "Test2", 2501, "Electronics"));
        }
    }
}
