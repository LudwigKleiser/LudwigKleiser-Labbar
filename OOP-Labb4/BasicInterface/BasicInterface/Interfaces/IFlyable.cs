using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.Interfaces
{
    // Interfaces define _what_ something can do, is, has etc.
    interface IFlyable
    {
        
        int TopSpeed { get; set; }
        void Fly();

    }
}
