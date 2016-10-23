using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb4
{
    class VehicleHandeler
    {

        public static void ShowAllVehicles()
        {
            Console.Clear();
            Console.WriteLine("Cars");
            foreach (Car car in Car.cars)
            {
                Console.WriteLine("Manufacturer: {0} Value: {1}$ Model: {2} and {3} number of units: {4}"
                    , car.Manufacturer, car.Price, car.Model, BoolToPrint(car.IsUsed), car.NumberOfUnits);
            }
            Console.WriteLine("\nBikes");
            foreach (Motorbike motorbike in Motorbike.bikes)
            {
                Console.WriteLine("Manufacturer: {0} Value: {1}$ Model: {2} and {3} number of units {4}"
                    , motorbike.Manufacturer, motorbike.Price, motorbike.Model, BoolToPrint(motorbike.IsUsed), motorbike.NumberOfUnits);
            }
            Console.ReadKey(true);



        }


        public static void SearchForCar()
        {
            Console.Clear();
            Console.WriteLine("Seach for model");
            string carToSearch = Console.ReadLine();

            Car[] subset = Car.cars
                .Where(car => car.Model.Equals(carToSearch))
                .ToArray();
            foreach (var car in subset)
            {
                Console.WriteLine("You have:{0} {1}(s)", car.NumberOfUnits, car.Model);
            }


           //Console.WriteLine("You have {0} {1}(s)", subset.Length, carToSearch);

            //Car singleCar = Car.cars.SingleOrDefault(car => String.Equals(car, carToSearch));
            //Console.WriteLine("You have{0} {1}(s)", singleCar.Model, carToSearch);
            //Console.ReadKey(true);




            Console.ReadKey(true);
        }

        public static void SearchForMotorBike()
        {
            Console.Clear();

            Console.WriteLine("Seach for model");
            string motorBikeToSearch = Console.ReadLine();

            Motorbike[] subset = Motorbike.bikes
                .Where(bike => bike.Model.Equals(motorBikeToSearch))
                .ToArray();
            foreach (var bike in subset)
            {
                Console.WriteLine("You have:{0} {1}(s)", bike.NumberOfUnits, bike.Model);
            }


            Console.ReadKey(true);

        }
        public static void AddCar()
        {
            Console.Write("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price($): ");
            int price = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out price);
                if (!isNumber) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Has it been used? y/n");
            bool isUsed = false;
            bool isTrue = true;

            while (isTrue)
            {
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    isUsed = true;
                    isTrue = false;
                }

                else if (choice == "n")
                {
                    isUsed = false;
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("Please use a y or n");
                }

                Car.cars.Add(new Car(price, manufacturer, model, isUsed));


            }
        }
        public static void CarToRemove()
        {
            Menus.ShowAllCars();
            Console.WriteLine("\nSelect the car to remove");
            Console.Write("Choice: ");
            string removeCar = Console.ReadLine();
            int removeCar1 = Convert.ToInt32(removeCar);
            removeCar1--;
            Car.cars.RemoveAt(removeCar1);
            Console.WriteLine("Removed!");
            Console.ReadKey(true);

        }
        public static void AddMotorbike()
        {
            Console.Write("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();



            Console.Write("Price($): ");
            int price = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out price);
                if (!isNumber) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Has it been used? y/n");
            bool isUsed = false;
            bool isTrue = true;

            while (isTrue)
            {
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    isUsed = true;
                    isTrue = false;
                }

                else if (choice == "n")
                {
                    isUsed = false;
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("Please use a y or n");
                }


                Motorbike.bikes.Add(new Motorbike(price, manufacturer, model, isUsed));

            }
        }
        public static void MotorbikeToRemove()
        {
            Menus.ShowAllBikes();
            Console.WriteLine("\nSelect the bike to remove");
            Console.Write("Choice: ");
            string removeBike = Console.ReadLine();
            int removeBike1 = Convert.ToInt32(removeBike);
            removeBike1--;
            Motorbike.bikes.RemoveAt(removeBike1);
            Console.WriteLine("Removed!");
            Console.ReadKey(true);


        }
        public static string BoolToPrint(bool isUsed)
        {
            if (isUsed == true) return String.Format("is secondhand");
            else return String.Format("is not secondhand");



        }
        public static void DecideOnCar(bool sellOrBuy)
        {
            Menus.ShowAllCars();
            Console.WriteLine("\n Which one?");
            if (sellOrBuy == true)
            {
                string choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                choice1--;
                if (choice1 < Car.cars.Count && choice1 >= 0)
                {
                    NumberOfCars(Car.cars[choice1], true);
                }

            }
            else
            {
                string choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                choice1--;
                if (choice1 < Car.cars.Count && choice1 >= 0)
                {
                    NumberOfCars(Car.cars[choice1], false);
                }
            }


        }
        public static void DecideOnBike(bool sellOrBuy)
        {
            Menus.ShowAllBikes();
            Console.WriteLine("\n Which one?");
            if (sellOrBuy == true)
            {
                string choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                choice1--;
                if (choice1 < Motorbike.bikes.Count && choice1 >= 0)
                {
                    NumberOfBikes(Motorbike.bikes[choice1], true);
                }
            }
            else
            {
                string choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                choice1--;
                if (choice1 < Motorbike.bikes.Count && choice1 >= 0)
                {
                    NumberOfBikes(Motorbike.bikes[choice1], false);
                }
            }

        }
        public static void NumberOfCars(Car car, bool buyOrSell)
        {
            Console.WriteLine("How many?");
            if (buyOrSell == true)
            {
                int numberOfUnits = 0;
                bool isNumber = false;
                while (!isNumber)
                {
                    string input = Console.ReadLine();
                    isNumber = int.TryParse(input, out numberOfUnits);
                    if (!isNumber) Console.WriteLine("Please enter a number");
                }
                car.NumberOfUnits = car.NumberOfUnits + numberOfUnits;
            }

            else
            {
                int numberOfUnits = 0;
                bool isNumber = false;
                while (!isNumber)
                {
                    string input = Console.ReadLine();
                    isNumber = int.TryParse(input, out numberOfUnits);
                    if (!isNumber) Console.WriteLine("Please enter a number");
                }
                car.NumberOfUnits = car.NumberOfUnits - numberOfUnits;
            }
        }


        public static void NumberOfBikes(Motorbike bike, bool buyOrSell)
        {
            Console.WriteLine("How many?");
            if (buyOrSell == true)
            {
                int numberOfUnits = 0;
                bool isNumber = false;
                while (!isNumber)
                {
                    string input = Console.ReadLine();
                    isNumber = int.TryParse(input, out numberOfUnits);
                    if (!isNumber) Console.WriteLine("Please enter a number");
                }
                bike.NumberOfUnits = bike.NumberOfUnits + numberOfUnits;
            }
            else
            {
                int numberOfUnits = 0;
                bool isNumber = false;
                while (!isNumber)
                {
                    string input = Console.ReadLine();
                    isNumber = int.TryParse(input, out numberOfUnits);
                    if (!isNumber) Console.WriteLine("Please enter a number");
                }
                bike.NumberOfUnits = bike.NumberOfUnits - numberOfUnits;
            }
        }

    }
}

