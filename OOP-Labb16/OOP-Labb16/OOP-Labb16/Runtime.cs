using OOP_Labb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb16
{
    class Runtime
    {
        public void Start()
        {
            var listProductRepository = new ListProductRepository();
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Get");
                Console.WriteLine("4. Get All");
                Console.WriteLine("");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        listProductRepository.Add();
                        break;

                    case ConsoleKey.D2:
                        listProductRepository.DecideOnDelete();
                        break;

                    case ConsoleKey.D3:
                        listProductRepository.DecideOnProduct();
                        break;

                    case ConsoleKey.D4:
                        listProductRepository.GetAll();
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D5:

                        break;

                    case ConsoleKey.D6:

                        break;

                    default:

                        break;
                }
            }
        }
    }
}
