using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb4
{
    public abstract class Vehicle
    {
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public bool IsUsed { get; set; }
        public int NumberOfUnits { get; set; } = 0;
       


    }
}