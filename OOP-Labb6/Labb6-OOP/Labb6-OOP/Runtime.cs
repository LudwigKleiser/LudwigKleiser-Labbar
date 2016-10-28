using Labb6_OOP.Models.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP
{
    class Runtime
    {
        public static bool isWin = false;
        public static IEnvironment CurrentEnviroment { get; set; }

        public void Start()
        {
            EnviromentCreator();
            CurrentEnviroment = Lists.Enviroments[0];
            LoopForGame();
            Console.WriteLine("You win!");
            Console.ReadKey(true);

        }

        private void EnviromentCreator()
        {
            Room newRoom = new Room(0, "You are in a big room", "You see a man in the corner of the room");
            newRoom.NonPlayerCharacter.Add(new QuestGiver { Name = "Man" });
            Lists.Enviroments.Add(newRoom);
            
               


            newRoom = new Room(1, "You are in a medium sized room", "You see scaps of hay across the floor");
            Lists.Enviroments.Add(newRoom);

            Yard newYard = new Yard(2, "You are outside", "You see a horse");
            newYard.NonPlayerCharacter.Add(new Horse());
            Lists.Enviroments.Add(newYard);

            newRoom = new Room(3, "You are in a small room", "You see a small table");
            Lists.Enviroments.Add(newRoom);



        }

        private void LoopForGame()
        {
            while (!isWin)
            {

            }
        }
    }
}
