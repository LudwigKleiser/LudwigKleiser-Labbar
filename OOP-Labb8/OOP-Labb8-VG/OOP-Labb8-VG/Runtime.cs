using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb8_VG
{
    class Runtime
    {
        
        public void Start()
        {
            var productManager = new ProductManager();
            Graphics.MainMenu(productManager);

            //StringConcatinator stringConcatinator = StringConcatinatorMethod;
            //NumberOperator numberOperator = NumberOperatorMethod;

            //Console.WriteLine(stringConcatinator(stringCollection));
            //Console.WriteLine(numberOperator(floatCollection, true));
            //Console.WriteLine(numberOperator(floatCollection, false));

        }
    }
}
