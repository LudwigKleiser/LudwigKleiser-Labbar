using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    class EventHandeler
    {
        public static List<Cinema> cinemas = new List<Cinema>();
        public static List<Festival> festivals = new List<Festival>();
        public static List<Concert> concerts = new List<Concert>();
        

        public static void ConcertMadonnaAdd()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();

            Concert newConcert = new Concert { Name = "Madonna", Price = 50, Location = "Eriksson Globe", UserName = userName };
            Console.WriteLine(newConcert.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) concerts.Add(newConcert);
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");

            


            

        }
        public static void ConcertJustinTimberlake()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Concert newConcert = new Concert { Name = "Justin TimberLake", Price = 45, Location = "Friends Arena", UserName = userName };
            Console.WriteLine(newConcert.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) concerts.Add(newConcert);
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");
            

        }
        public static void FestivalCoachellaAdd()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Festival newFestival = new Festival { Name = "Coachella", Price = 150, Location = "Indio", UserName = userName };
            Console.WriteLine(newFestival.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) festivals.Add(newFestival); 
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");
            

        }
        public static void FestivalUltraAdd()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Festival newFestival = new Festival { Name = "Ultra", Price = 250, Location = "Miami", UserName = userName };
            Console.WriteLine(newFestival.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) festivals.Add(newFestival);
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");
            festivals.Add(newFestival);
        }
        public static void CinemaBatmanAdd()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Cinema newCinema = new Cinema { Name = "Batman", Price = 10, Location = "Heron City", UserName = userName };
            Console.WriteLine(newCinema.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) cinemas.Add(newCinema); 
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");
            
        
        }
        public static void CinemaSupermanAdd()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();

            Cinema newCinema = new Cinema { Name = "Superman", Price = 12, Location = "Sergels Torg", UserName = userName };
            Console.WriteLine(newCinema.ShowInfo());
            Console.WriteLine("Do you want to buy this ticket {0}? (y/n)", userName);

            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Y) cinemas.Add(newCinema);
            else if (input == ConsoleKey.N) Console.WriteLine("Okay!");
            
        }
        public static void ShowEvents()
        {
            Console.Clear();

            foreach (Cinema cinema in cinemas)
            {
                Console.WriteLine("Tickerholder: {0} Movie: {1} Price: {3} Location: {2}$", cinema.UserName, cinema.Name, cinema.Location, cinema.Price);
            }
            foreach (Festival festival in festivals)
            {
                Console.WriteLine("Ticketholder: {0} Festival: {1}  Price: {2}$ Location: {3}", festival.UserName, festival.Name, festival.Price, festival.Location);
            }
            foreach (Concert concert in concerts)
            {
                Console.WriteLine("Ticketholder: {0} Performance by: {1} Price: {2}$ Location: {3}", concert.UserName, concert.Name, concert.Price, concert.Location);
            }
            Console.ReadKey(true);
        }
    }
}
