using OOP_Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb15.Models
{
    class Button : IPushable
    {
        

        public string Push()
        {
            return String.Format("You push the button");
        }
    }
}
