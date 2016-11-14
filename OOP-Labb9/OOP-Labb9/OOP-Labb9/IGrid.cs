using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb9
{
    interface IGrid
    {
        void PlaceMarker(int row, int col, int player, Node[,] playerNodes, Runtime runtime);
       
    }
}
