using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb8_VG
{
    class Graphics
    {
        
        public static void MainMenu(ProductManager productManger)
        {
            ProductManager.StringConcatinator formattedStrings = (message) =>
            {
                Console.WriteLine(message);
            };

            ProductManager.NumberOperator formattedNumberString = (message) =>
            {
                Console.WriteLine(message);
            };
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.WriteLine("1 List products.");
                Console.WriteLine("2 Add 20%.");
                Console.WriteLine("3. Remove 10% from 1000$ products.");
                Console.WriteLine("4. Quit");
                var input = Console.ReadKey(true).Key;
                switch(input)
                {
                    case ConsoleKey.D1:
                        productManger.FormatProductNames(formattedStrings);
                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:

                        break;

                    case ConsoleKey.D4:

                        break;
                    default:
                        Console.WriteLine("wrong");
                        break;
                }
            }
        }
    }
}
