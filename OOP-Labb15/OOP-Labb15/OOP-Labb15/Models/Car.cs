using OOP_Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb15.Models
{
    class Car : IVehicle
    {
        public bool IsLocked { get; set; }

        public string Lock()
        {
            if (IsLocked)
            {
                return String.Format("The car is already locked!");
            }
            else
            {
                IsLocked = true;
                return String.Format("You lock the car");
            }
        }

        public string Start()
        {
            return String.Format("You start the car");
        }

        public string Stop()
        {
            return String.Format("You stop the car");
        }

        public string Unlock()
        {
            if (IsLocked)
            {
                IsLocked = false;
                return String.Format("You unlock the car");
            }

            else return String.Format("The car is already unlocked!");
           
        }
    }
}
