using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb7
{
    interface ISellable
    {
         int Price { get; set; }         
         string ProductName { get; set; }
         string Brand { get; set; }
         string Type { get; set; }


        void  Description();

       
    }
}
