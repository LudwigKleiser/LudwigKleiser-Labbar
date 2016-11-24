using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb15.Interfaces
{
    interface IVehicle
    {
        string Start();
        string Stop();
        string Lock();
        string Unlock();
    }
}
