using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb4
{
    class Runtime
    {
        public void Start()
        {
            SomeHelp();
            bool loop = true;
            while (loop)
            {
                Menus.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        bool stockMenuLoop = true;
                        while (stockMenuLoop)
                        {
                            Menus.CheckStockMenu();

                            var stockInput = Console.ReadKey(true).Key;
                            if (stockInput == ConsoleKey.D1) VehicleHandeler.ShowAllVehicles();
                            else if (stockInput == ConsoleKey.D2)
                            {
                                bool carOrBikeLoop = true;
                                while (carOrBikeLoop)
                                {
                                    Menus.CarOrMotorBikeMenu();
                                    var carOrBikeInput = Console.ReadKey(true).Key;
                                    if (carOrBikeInput == ConsoleKey.D1)
                                    {
                                        VehicleHandeler.SearchForCar();
                                        carOrBikeLoop = false;
                                    }
                                    else if (carOrBikeInput == ConsoleKey.D2)
                                    {
                                        VehicleHandeler.SearchForMotorBike();
                                        carOrBikeLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid command, press any key to try again");
                                        Console.ReadKey(true);
                                    }
                                }
                            }
                            else if (stockInput == ConsoleKey.D3) stockMenuLoop = false;

                            else
                            {
                                Console.WriteLine("Please enter a valid command, press any key to try again");
                                Console.ReadKey(true);
                            }

                        }




                        break;

                    case ConsoleKey.D2:
                        bool addOrRemoveLoop = true;
                        while (addOrRemoveLoop)
                        {
                            Menus.AddOrRemoveMenu();
                            var addOrRemoveInput = Console.ReadKey(true).Key;
                            if (addOrRemoveInput == ConsoleKey.D1)
                            {

                                bool add = true;
                                while (add)
                                {

                                    Menus.CarOrMotorBikeMenu();
                                    var carOrBikeInput = Console.ReadKey(true).Key;
                                    if (carOrBikeInput == ConsoleKey.D1)
                                    {
                                        VehicleHandeler.AddCar();
                                        add = false;
                                    }
                                    else if (carOrBikeInput == ConsoleKey.D2)
                                    {
                                        VehicleHandeler.AddMotorbike();
                                        add = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid command, press any key to try again");
                                        Console.ReadKey(true);
                                    }

                                }
                            }

                            else if (addOrRemoveInput == ConsoleKey.D2)
                            {
                                bool remove = true;
                                while (remove)
                                {
                                    Menus.CarOrMotorBikeMenu();
                                    var carOrBikeInput = Console.ReadKey(true).Key;
                                    if (carOrBikeInput == ConsoleKey.D1)
                                    {
                                        VehicleHandeler.CarToRemove();
                                        remove = false;
                                    }
                                    else if (carOrBikeInput == ConsoleKey.D2)
                                    {
                                        VehicleHandeler.MotorbikeToRemove();
                                        remove = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid command, press any key to try again");
                                        Console.ReadKey(true);
                                    }
                                }
                            }
                            else if (addOrRemoveInput == ConsoleKey.D3) addOrRemoveLoop = false;
                            else
                            {
                                Console.WriteLine("Please enter a valid command, press any key to try again");
                                Console.ReadKey(true);
                            }
                        }
                        break;

                    case ConsoleKey.D3:
                        bool buyOrSellLoop = true;
                        while (buyOrSellLoop)
                        {
                            Menus.BuyOrSellMenu();
                            var buyOrSell = Console.ReadKey(true).Key;

                            if (buyOrSell == ConsoleKey.D1)
                            {
                                bool buyLoop = true;
                                while (buyLoop)
                                {
                                    Menus.CarOrMotorBikeMenu();
                                    var buyInput = Console.ReadKey(true).Key;
                                    if (buyInput == ConsoleKey.D1)
                                    {
                                        VehicleHandeler.DecideOnCar(true);
                                        buyLoop = false;

                                    }
                                    else if (buyInput == ConsoleKey.D2)
                                    {
                                        VehicleHandeler.DecideOnBike(true);
                                        buyLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid command, press any key to try again");
                                        Console.ReadKey(true);
                                    }

                                }
                            }

                            else if (buyOrSell == ConsoleKey.D2)
                            {
                                bool sellLoop = true;
                                while (sellLoop)
                                {
                                    Menus.CarOrMotorBikeMenu();
                                    var sellInput = Console.ReadKey(true).Key;
                                    if (sellInput == ConsoleKey.D1)
                                    {

                                        VehicleHandeler.DecideOnCar(false);
                                        sellLoop = false;
                                    } 
                                    else if (sellInput == ConsoleKey.D2)
                                    {
                                        
                                        VehicleHandeler.DecideOnBike(false);
                                        sellLoop = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid command, press any key to try again");
                                        Console.ReadKey(true);
                                    }

                                }
                            }

                            else if (buyOrSell == ConsoleKey.D3) buyOrSellLoop = false;

                            else
                            {
                                Console.WriteLine("Please enter a valid command, press any key to try again");
                                Console.ReadKey(true);
                            }
                        }
                        break;

                    case ConsoleKey.D4:
                        loop = false;

                        break;

                    default:
                        Console.WriteLine("Please enter a valid command, press any key to try again");
                        Console.ReadKey(true);
                        break;
                }
            }

        }

        private void SomeHelp()
        {
            Car c1 = new Car(25000, "Volvo", "V70", true);
            Car c2 = new Car(2700000, "Ferrari", "LaFerrari", false);
            Car c3 = new Car(30000, "Saab", "V70", true);
            Car c4 = new Car(40000, "Saab", "C80", false);
            Car c5 = new Car(2500000, "Lamborgini", "Aventador", false);
            Car.cars.Add(c1);
            Car.cars.Add(c2);
            Car.cars.Add(c3);
            Car.cars.Add(c4);
            Car.cars.Add(c5);

           



            Motorbike b1 = new Motorbike(230, "Honda", "Ar15", true);
            Motorbike b2 = new Motorbike(3500, "Honda", "CC50", false);
            Motorbike b3 = new Motorbike(340, "Harley Davidsson", "R90", true);
            Motorbike b4 = new Motorbike(400, "Toyota", "KL50", false);
            Motorbike b5 = new Motorbike(2000, "Subaru", "C80", false);
            Motorbike.bikes.Add(b1);
            Motorbike.bikes.Add(b2);
            Motorbike.bikes.Add(b3);
            Motorbike.bikes.Add(b4);
            Motorbike.bikes.Add(b5);

           


        }
    }
}
