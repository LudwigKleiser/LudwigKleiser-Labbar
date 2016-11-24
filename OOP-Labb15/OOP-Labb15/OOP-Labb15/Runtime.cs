using OOP_Labb15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb15
{
    class Runtime
    {
        
        public void Start()
        {
            var car1 = new Car { IsLocked = true };
            var car2 = new Car { IsLocked = false };
            var boulder1 = new Boulder { Weight = 21 };
            var boulder2 = new Boulder { Weight = 19 };
            //Console.WriteLine(car1.Start());
            //Console.WriteLine(car1.Stop());
            //Console.WriteLine(car1.Lock());
            //Console.WriteLine(car1.Unlock());

            //Console.WriteLine(car2.Start());
            //Console.WriteLine(car2.Stop());
            //Console.WriteLine(car2.Lock());
            //Console.WriteLine(car2.Unlock());

            //Console.WriteLine(car1.Lock());
            //Console.WriteLine(car2.Lock());
            Console.WriteLine(car1.Unlock());
            Console.WriteLine(car2.Unlock());
            Console.WriteLine(boulder1.Push());
            Console.WriteLine(boulder2.Push());
        }
    }
}
