using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP.Models.Creatures
{
    class Horse : Animal
    {
        
        public override string Observe()
        {
            return "You see a horse";
        }

        public override void Talk()
        {
            if (QuestGiver.Quest == QuestGiver.QuestStatus.NotStarted)
            {
                Console.WriteLine("You´re uncertain of what to do here");
                return;

            }

            else if(QuestGiver.Quest == QuestGiver.QuestStatus.Halfway)
            {
                Console.WriteLine("This must be the horse the man was looking for. Will you take it (y/n)");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("You mount the horse");
                        QuestGiver.Quest = QuestGiver.QuestStatus.Completed;
                        return;

                    case ConsoleKey.N:
                        Console.WriteLine("You leave the horse alone");
                        return;
                }
            }
        }
    }
}
