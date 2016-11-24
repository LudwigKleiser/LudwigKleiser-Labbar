using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb16.Models
{
    class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }


        List<Product> Products { get; set; }

       
    }
}
