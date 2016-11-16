using OOP_Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb13.Filters
{
    class ItemFilters
    {
        public static bool IsCheap(Item item)
        {
            return item.Worth < 12;
        }

        public static bool IsOld(Item item)
        {
            return item.Age > 4;
        }

        public static bool IsFresh(Item item)
        {
            return item.Age < 2;
        }

        
    }
}
