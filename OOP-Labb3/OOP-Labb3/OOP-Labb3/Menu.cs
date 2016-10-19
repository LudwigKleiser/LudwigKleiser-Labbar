using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    class Menu
    {

        public static void MainMenu()
        {
            Console.WriteLine("Please enter your name");
            
        }

        public static void EventMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Concert");
            Console.WriteLine("2. Cinema");
            Console.WriteLine("3. Festival");
            Console.WriteLine("4. Show booked events");
            Console.WriteLine("5. Quit");
            Console.Write("Choice");
        }

        public static void ConcertChoicesMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Madonna");
            Console.WriteLine("2. Justin Timberlake");
            Console.WriteLine("3. Go Back");

            Console.Write("Choice: ");
        }
        public static void CinemaChoicesMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Batman");
            Console.WriteLine("2. Superman");
            Console.WriteLine("3. Go back");
            Console.Write("Choice: ");
        }
        public static void FestivalChoicesMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Coachella");
            Console.WriteLine("2. Ultra");
            Console.WriteLine("3. Go back");
            Console.Write("Choice: ");
        }
    }
}
