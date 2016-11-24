using OOP_Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb15.Models
{
    class Boulder : IPushable
    {
        public int Weight { get; set; }

        public string Push()
        {
            if (Weight < 20) return String.Format("You push the boulder");
            else return String.Format("You are to weak to push this boulder");
        }
    }
}
