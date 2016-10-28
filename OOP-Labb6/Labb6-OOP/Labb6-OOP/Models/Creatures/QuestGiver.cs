using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP.Models.Creatures
{
    class QuestGiver : Human
    {
       public enum QuestStatus
        {
            NotStarted = 1,
            Halfway,
            Completed
        }
        public static QuestStatus Quest { get; set; } = QuestStatus.NotStarted;
       
        

        public override string Observe()
        {
            return "You see a man";
        }

        public override void Talk()
        {
           if(QuestStatus.NotStarted == Quest)
            {
                Console.WriteLine("I lost my horse! Can you find it for me? (y/n)");
                var input = Console.ReadKey(true).Key;
                switch(input)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("Thank you!");
                        Quest = QuestStatus.Halfway;
                        return;

                        

                    case ConsoleKey.N:
                        Console.WriteLine("Do come back if you change your mind");
                        return;

                    default:
                        Console.WriteLine("Please enter a valid command next time");
                        return;
                }

            }

           else if (QuestStatus.Halfway == Quest)
            {
                Console.WriteLine("Please find my horse!");
            }

           else
            {
                Console.WriteLine("Thank you so much!");
                Quest = QuestStatus.Completed;
                Runtime.isWin = true;            }
        }
       
    }
    
}
