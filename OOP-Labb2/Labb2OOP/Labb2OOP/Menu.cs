using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2OOP
{
    class Menu
    {
        static int userValue;

        public static void ShowMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1 Add animal");
                Console.WriteLine("2 Remove animal");
                Console.WriteLine("3 Show animals");
                Console.WriteLine("4 Quit");
                Console.Write("Choice: ");


                int.TryParse(Console.ReadLine(), out userValue);

                switch (userValue)
                {
                    case 1:
                        AddAnimal();

                        break;

                    case 2:
                        RemoveAnimal();

                        break;

                    case 3:
                        PrintAllAnimals();

                        break;

                    case 4:
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.WriteLine("Click on any key to return");
                        Console.ReadKey(true);

                        break;
                }

            }
        }

        private static void RemoveAnimal()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Mammals");
                Console.WriteLine("2. Birds");
                Console.WriteLine("3. Reptiles");
                Console.WriteLine("4 Go back");

                int userValue;
                int.TryParse(Console.ReadLine(), out userValue);

                switch (userValue)
                {
                    case 1:
                        PrintDogs();
                        Console.WriteLine("\nSelect the dog to remove");
                        Console.Write("Choice: ");
                        string removeDog = Console.ReadLine();
                        int removeDog1 = Convert.ToInt32(removeDog);
                        removeDog1--;
                        Lists.Dogs.RemoveAt(removeDog1);


                        Console.ReadKey(true);

                        return;

                    case 2:
                        PrintOwls();
                        Console.WriteLine("\nSelect the owl to remove");
                        Console.Write("Choice: ");
                        string removeBird = Console.ReadLine();
                        int removeBird1 = Convert.ToInt32(removeBird);
                        removeBird1--;
                        Lists.Owls.RemoveAt(removeBird1);

                        Console.ReadKey(true);

                        return;

                    case 3:
                        PrintSnakes();
                        Console.WriteLine("\nSelect the snake to remove");
                        Console.Write("Choice: ");
                        string removeSnake = Console.ReadLine();
                        int removeSnake1 = Convert.ToInt32(removeSnake);
                        removeSnake1--;
                        Lists.Snakes.RemoveAt(removeSnake1);
                        Console.ReadKey(true);

                        return;

                    case 4:

                        return;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.WriteLine("Click on any key to return");
                        Console.ReadKey(true);

                        break;
                }

            }
        }

        private static void PrintSnakes()
        {
            int i = 1;
            foreach (Snake snake in Lists.Snakes)
            {
                Console.WriteLine("{0}. {1}", i, snake.Name);
                i++;

            }
        }

        private static void PrintOwls()
        {
            int i = 1;
            foreach (Owl Owl in Lists.Owls)
            {
                Console.WriteLine("{0}. {1}", i, Owl.Name);
                i++;

            }

        }

        private static void PrintDogs()
        {
            int i = 1;
            foreach (Dog dog in Lists.Dogs)
            {
                Console.WriteLine("{0}. {1}", i, dog.Name);
                i++;

            }

        }

        private static void PrintAllAnimals()
        {
            int i = 1;
            foreach (Dog dog in Lists.Dogs)
            {
                Console.WriteLine("[{0}]" + dog.PresentAnimal(), i);

                i++;
            }

            foreach (Snake snake in Lists.Snakes)
            {
                Console.WriteLine("[{0}]" + snake.PresentAnimal(), i);
                i++;
            }


            foreach (Owl owl in Lists.Owls)
            {
                Console.WriteLine("[{0}]" + owl.PresentAnimal(), i);
                i++;

            }
            Console.ReadKey(true);
        }

        private static void AddAnimal()
        {
            bool start = true;

            while (start)
            {

                Console.WriteLine("Please choose which type of animal you would like to add");
                Console.WriteLine("[1] Mammal");
                Console.WriteLine("[2] Reptile");
                Console.WriteLine("[3] Bird");
                Console.WriteLine("[4] Go back");
                Console.Write("Choice: ");

                int.TryParse(Console.ReadLine(), out userValue);

                switch (userValue)
                {
                    case 1:
                        AddDog();

                        return;

                    case 2:
                        AddSnake();

                        return;

                    case 3:
                        AddOwl();

                        return;

                    case 4:

                        return;



                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.WriteLine("Click on any key to return");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private static void AddOwl()
        {
            Console.WriteLine("Age: ");
            int age = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out age);
                if (!isNumber) Console.WriteLine("Please enter a number");
            }

            Console.Write("Weight: ");
            int weight = 0;
            bool isNumber1 = false;
            while (!isNumber1)
            {
                string input = Console.ReadLine();
                isNumber1 = int.TryParse(input, out weight);
                if (!isNumber1) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Number of legs: ");
            int numberOfLegs = 0;
            bool isNumber2 = false;
            while (!isNumber2)
            {
                string input = Console.ReadLine();
                isNumber2 = int.TryParse(input, out numberOfLegs);
                if (!isNumber2) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("How many feathers does it have?");
            int numberOfFeathers = 0;
            bool isNumber3 = false;
            while (!isNumber3)
            {
                string input = Console.ReadLine();
                isNumber3 = int.TryParse(input, out numberOfFeathers);
                if (!isNumber3) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Can it fly? y/n");
            bool canFly = false;
            bool isTrue = true;

            while (isTrue)
            {
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    canFly = true;
                    isTrue = false;
                }

                else if (choice == "n")
                {
                    canFly = false;
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("Please use a y or n");
                }
            }
            Lists.Owls.Add(new Owl(age, weight, numberOfLegs, name, canFly, numberOfFeathers));

        }

        private static void AddSnake()
        {
            Console.WriteLine("Age: ");
            int age = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out age);
                if (!isNumber) Console.WriteLine("Please enter a number");
            }

            Console.Write("Weight: ");
            int weight = 0;
            bool isNumber1 = false;
            while (!isNumber1)
            {
                string input = Console.ReadLine();
                isNumber1 = int.TryParse(input, out weight);
                if (!isNumber1) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Number of legs: ");
            int numberOfLegs = 0;
            bool isNumber2 = false;
            while (!isNumber2)
            {
                string input = Console.ReadLine();
                isNumber2 = int.TryParse(input, out numberOfLegs);
                if (!isNumber2) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("How many times a year does it shred i´ts skin: ");
            int shredSkinAYear = 0;
            bool isNumber3 = false;
            while (!isNumber3)
            {
                string input = Console.ReadLine();
                isNumber3 = int.TryParse(input, out shredSkinAYear);
                if (!isNumber3) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Does it have a split tongue? y/n");
            bool splitTongue = false;
            bool isTrue = true;

            while (isTrue)
            {
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    splitTongue = true;
                    isTrue = false;
                }

                else if (choice == "n")
                {
                    splitTongue = false;
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("Please use a y or n");
                }
            }
            Lists.Snakes.Add(new Snake(age, weight, numberOfLegs, name, shredSkinAYear, splitTongue));

        }

        private static void AddDog()
        {
            Console.WriteLine("Age: ");
            int age = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out age);
                if (!isNumber) Console.WriteLine("Please enter a number");
            }

            Console.Write("Weight: ");
            int weight = 0;
            bool isNumber1 = false;
            while (!isNumber1)
            {
                string input = Console.ReadLine();
                isNumber1 = int.TryParse(input, out weight);
                if (!isNumber1) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Number of legs: ");
            int numberOfLegs = 0;
            bool isNumber2 = false;
            while (!isNumber2)
            {
                string input = Console.ReadLine();
                isNumber2 = int.TryParse(input, out numberOfLegs);
                if (!isNumber2) Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("Name: ");
            String name = Console.ReadLine();



            Console.WriteLine("Can it swim? y/n");
            bool canSwim = false;
            bool isTrue = true;

            while (isTrue)
            {
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    canSwim = true;
                    isTrue = false;
                }

                else if (choice == "n")
                {
                    canSwim = false;
                    isTrue = false;
                }

                else
                {
                    Console.WriteLine("Please use a y or n");
                }

                Console.WriteLine("Does it have a fluffytail? y/n");
                bool fluffyTail = false;
                bool isTrue1 = true;

                while (isTrue1)
                {
                    string choice1 = Console.ReadLine();

                    if (choice1 == "y")
                    {
                        fluffyTail = true;
                        isTrue1 = false;
                    }

                    else if (choice1 == "n")
                    {
                        fluffyTail = false;
                        isTrue1 = false;
                    }

                    else
                    {
                        Console.WriteLine("Please use a y or n");
                    }
                }
                Lists.Dogs.Add(new Dog(age, weight, numberOfLegs, name, canSwim, fluffyTail));


            }
        }
    }
}
