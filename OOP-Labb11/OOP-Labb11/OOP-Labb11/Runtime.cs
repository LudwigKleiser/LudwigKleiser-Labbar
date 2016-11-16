using OOP_Labb11.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb11
{
    
    class Runtime
    {
        
        private event AnalyzeNumber NumberInput;
        
        public void Start()
        {
            
            NumberInput += NumberFilters.IsEven;
            NumberInput += NumberFilters.IsDividableThree;
            NumberInput += NumberFilters.IsPrimeNumber;


            while (true)
            {

                
                Console.Clear();
                Console.WriteLine("Write numbero ");
                int number = Convert.ToInt32(Console.ReadLine());

                NumberInput(number);
               
               
                Console.ReadKey(true);
            }

        }
       
        
    }
}
