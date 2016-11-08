using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb7
{
    public class Medicine : Product
    {
        public  Medicine(string name, string brand, int price, string type)
        {
            ProductName = name;
            Brand = brand;
            Price = price;
            Type = type;

        }
    }
}