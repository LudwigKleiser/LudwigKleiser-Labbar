using OOP_Labb13.Filters;
using OOP_Labb13.Managers;
using OOP_Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb13
{
    class Runtime
    {
        private event PrintMessage WrongInput;

       
	
		ItemFilter isCheapFilter = ItemFilters.IsCheap;
        ItemFilter isOldFilter = ItemFilters.IsOld;
        ItemFilter isFreshFilter = ItemFilters.IsFresh; 
    

        public void Start()
        {
            WrongInput += new PrintMessage(WrongInputErrorMessage);
            
            ItemManager manager = new ItemManager();

            while (true)
            {
                UserMenus.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:

                        FilterMethod(manager);
                        break;

                    case ConsoleKey.D2:
                        manager.AddNewProduct(this);
                        break;

                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;

                    default:
                        OnWrongInput("Wrong input");
                        break;
                }
            }
        }

        private void FilterMethod(ItemManager manager)
        {
            bool showProductLoop = true;
            manager.ShowAllProducts();
            while (showProductLoop)
            {
                UserMenus.FilterMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.PrintWhere(isCheapFilter);
                        break;

                    case ConsoleKey.D2:
                        manager.PrintWhere(isOldFilter);
                        break;

                    case ConsoleKey.D3:
                        manager.PrintWhere(isFreshFilter);
                        break;

                    case ConsoleKey.D4:
                        showProductLoop = false;
                        break;
                                         

                    default:
                        OnWrongInput("Wrong input");

                        break;
                }
            }
        }        
        public void WrongInputErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void OnWrongInput(string message)
        {
            WrongInput?.Invoke(message);
        }
    }
}
