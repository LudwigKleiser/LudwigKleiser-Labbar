using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb4
{
    public class Motorbike : Vehicle
    {
        public static List<Motorbike> bikes = new List<Motorbike>();
        

        public Motorbike(int price, string manufacturer, string model, bool isUsed)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            IsUsed = isUsed;

        }
        public Motorbike(int numberOfUnits)
        {
            NumberOfUnits = numberOfUnits;
        }
        
    }
}