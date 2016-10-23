using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb4
{
    public class Car : Vehicle
    {
        public static List<Car> cars = new List<Car>();
        

        public Car(int price, string manufacturer, string model, bool isUsed)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            IsUsed = isUsed;

        }

        public Car(int numberOfUnits)
        {
            NumberOfUnits = numberOfUnits;

        }

        
        
    }
}