using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3
{
    class Runtime
    {

        public void Start()
        {
            bool loop = true;
            while (loop)
            {
                Menu.EventMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        bool concertLoop = true;

                        while (concertLoop)
                        {
                            Menu.ConcertChoicesMenu();

                            int concertChoice = int.Parse(Console.ReadLine());
                            if (concertChoice == 1)
                            {
                                EventHandeler.ConcertMadonnaAdd();
                                concertLoop = false;
                            }
                            else if (concertChoice == 2)
                            {
                                EventHandeler.ConcertJustinTimberlake();
                                concertLoop = false;

                            }
                            else if (concertChoice == 3)
                            {
                                concertLoop = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey(true);
                            }
                        }
                        break;

                    case ConsoleKey.D2:
                        bool cinemaLoop = true;
                        while (cinemaLoop)
                        {
                            Menu.CinemaChoicesMenu();
                            int cinemaChoice = int.Parse(Console.ReadLine());
                            if (cinemaChoice == 1)
                            {
                                EventHandeler.CinemaBatmanAdd();
                                cinemaLoop = false;
                            }
                            else if (cinemaChoice == 2)
                            {
                                EventHandeler.CinemaSupermanAdd();
                                cinemaLoop = false;
                            }
                            else if (cinemaChoice == 3)
                            {
                                cinemaLoop = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey(true);

                            }
                        }



                        break;

                    case ConsoleKey.D3:
                        bool festivalLoop = true;
                        while (festivalLoop)
                        {
                            Menu.FestivalChoicesMenu();
                            int festivalChoice = int.Parse(Console.ReadLine());
                            if (festivalChoice == 1)
                            {
                                EventHandeler.FestivalCoachellaAdd();
                                festivalLoop = false;
                            }
                            else if (festivalChoice == 2)
                            {
                                EventHandeler.FestivalUltraAdd();
                                festivalLoop = false;
                            }
                            else if (festivalChoice == 3)
                            {
                                festivalLoop = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey(true);

                            }
                        }
                        break;

                    case ConsoleKey.D4:
                        EventHandeler.ShowEvents();

                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Please make a valid choice, press any key to return");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
