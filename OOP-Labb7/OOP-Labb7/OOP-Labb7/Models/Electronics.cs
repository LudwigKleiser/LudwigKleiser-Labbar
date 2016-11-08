using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb7
{
    class Electronics : Product
    {
        public  Electronics(string name, string brand, int price, string type)
        {
            ProductName = name;
            Brand = brand;
            Price = price;
            Type = type;

        }
    }
}
