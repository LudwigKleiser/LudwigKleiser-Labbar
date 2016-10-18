using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2OOP
{
    class Runtime
    {
        public void Start()
        {
            AddSomeAnimals();
            Menu.ShowMenu();

           
        }

        public void AddSomeAnimals()
        {
            
            Dog dog = new Dog(12, 25, 4, "Ludde", true, true);
            Dog dog1 = new Dog(12, 25, 4, "Hassan", false, false);
            Snake snake = new Snake(25, 1, 0, "Ronja", 10, true);
            Snake snake1 = new Snake(25, 1, 0, "Snakey", 10, false);
            Owl owl = new Owl(30, 6, 2, "Test", true, 40);
            Owl owl1 = new Owl(30, 6, 2, "Owley", false, 40);

            Console.WriteLine(owl.PresentAnimal());
            Console.WriteLine(owl1.PresentAnimal());

            Console.WriteLine(snake.PresentAnimal());
            Console.WriteLine(snake1.PresentAnimal());

            Console.WriteLine(dog.PresentAnimal());
            Console.WriteLine(dog1.PresentAnimal());

            Console.WriteLine(snake.Talk());
            Console.WriteLine(snake.Move());

            Console.WriteLine(owl.Talk());
            Console.WriteLine(owl.Move());

            Console.WriteLine(dog.Talk());
            Console.WriteLine(dog.Move());

            Lists.Dogs.Add(dog);
            Lists.Dogs.Add(dog1);

            Lists.Owls.Add(owl);
            Lists.Owls.Add(owl1);

            Lists.Snakes.Add(snake);
            Lists.Snakes.Add(snake1);

            Console.WriteLine("Det här är bara ett test. Tryck på någon knapp för att gå vidare");
            Console.ReadKey(true);


        }
    }
}
