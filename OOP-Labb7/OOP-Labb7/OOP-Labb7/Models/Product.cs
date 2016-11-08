using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb7
{
    public abstract class Product : ISellable
    {
        
        public int Price { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public void Description()
        {
            Console.WriteLine("Type: {0}, Name: {1}, Brand: {2}, Price: {3}($)", Type, ProductName, Brand, Price);
        }

       
    }

        



        
        
        
    }
