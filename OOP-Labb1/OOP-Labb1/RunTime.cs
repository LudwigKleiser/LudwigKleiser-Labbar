using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb1
{
    class RunTime
    {
        List<Dog> dogs = new List<Dog>();
        public void Start()
        {
            //Dog d1 = new Dog("Ludde", 5, "Bulldog");
            //Dog d2 = new Dog("Dutten", 2, "Tax");
            //Dog d3 = new Dog("Plutten", 7, "Pug");


            //Console.WriteLine(d1.Name + " " + d1.Age + " " + d1.Breed);
            //Console.WriteLine(d2.Name + " " + d2.Age + " " + d2.Breed);
            //Console.WriteLine(d3.Name + " " + d3.Age + " " + d3.Breed);


            //dogs.Add(d1);
            //dogs.Add(d2);
            //dogs.Add(d3);

            //foreach (Dog dog in dogs)
            //{
            //    Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
            //}
            bool isRunning = true;
            while (isRunning)
            {
                //Console.Clear();
                Console.WriteLine("[1] Lägg till en ny hund");
                Console.WriteLine("[2] Ta bort hund");
                Console.WriteLine("[3] Visa alla hundar");
                Console.WriteLine("[4] Avsluta");
                int menyChoice;
                int.TryParse(Console.ReadLine(), out menyChoice);

                switch (menyChoice)
                {

                    case 1:

                        Console.WriteLine("Namn: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Ålder: ");
                        int year = 0;
                        bool isNumber = false;
                        while (!isNumber)
                        {
                            string input = Console.ReadLine();
                            isNumber = int.TryParse(input, out year);
                            if (!isNumber) Console.WriteLine("Vänligen ange en siffra");
                        }

                        Console.WriteLine("Ras: ");
                        string race = Console.ReadLine();

                        dogs.Add(new Dog(name, year, race));
                        break;

                    case 2:
                        if (!dogs.Any())
                        {
                            Console.WriteLine("Det finns inga hundar arkviet än!");
                            Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                            Console.ReadKey();


                        }
                        else
                        {
                            k

                            int i = 1;
                            foreach (Dog dog in dogs)
                            {
                                Console.WriteLine("[{0}]" + dog.DogFormatString(), i);
                                i++;
                            }
                            Console.WriteLine("Ange hundens siffra för att ta bort den");
                            Console.Write("Val: ");
                            string userValue = Console.ReadLine();
                            int userChoice = Convert.ToInt32(userValue);
                            userChoice--;
                            dogs.RemoveAt(userChoice);
                        }

                        break;

                    case 3:
                        if (!dogs.Any())
                        {
                            Console.WriteLine("Det finns inga hundar arkviet än!");
                            Console.WriteLine("Tryck på valfri knapp för att återgå till menyn");
                            Console.ReadKey();


                        }
                        else
                        {
                            foreach (Dog dog in dogs)
                            {
                                Console.WriteLine(dog.DogFormatString());
                            }
                        }
                        break;

                    case 4:

                        isRunning = false;
                        break;

                    default:

                        Console.WriteLine("Vänligen ange en siffra.");
                        break;
                }
            }

        }
    }
}
