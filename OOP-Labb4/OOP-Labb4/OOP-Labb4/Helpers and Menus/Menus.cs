using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb4
{
    class Menus
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Check stock");
            Console.WriteLine("2. Add or remove vehicle");
            Console.WriteLine("3. Buy or sell vehicle");
            Console.WriteLine("4. Quit");
        }
        public static void CheckStockMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Show entire stock");
            Console.WriteLine("2. Search for vehicle");
            Console.WriteLine("3. Return");
        }
        public static void AddOrRemoveMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add vehicle");
            Console.WriteLine("2. Remove vehicle");
            Console.WriteLine("3. Return");

        }
        public static void BuyOrSellMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Buy vehicle");
            Console.WriteLine("2. Sell vehicle");
            Console.WriteLine("3. Return");
        }

        public static void CarOrMotorBikeMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorbike");
        }

        public static void ShowAllCars()
        {
            Console.Clear();
            int i = 1;
            foreach (Car car in Car.cars)
            {
                
                Console.WriteLine("{0} {1} {2} and {3}", i, car.Manufacturer, car.Model, VehicleHandeler.BoolToPrint(car.IsUsed));
                i++;
            }
        }

        public static void ShowAllBikes()
        {
            Console.Clear();
            int i = 1;
            foreach (Motorbike bike in Motorbike.bikes)
            {
                
                Console.WriteLine("{0} {1} {2} and {3}", i, bike.Manufacturer, bike.Model, VehicleHandeler.BoolToPrint(bike.IsUsed));
                i++;

            }

        }


    }
}
