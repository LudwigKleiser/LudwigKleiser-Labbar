using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb11.Filters
{
    class NumberFilters
    {
        public static void IsEven(int number)
        {
            if (number % 2 == 0) Console.WriteLine("This number is even");
            else Console.WriteLine("This number is not even");

        }

        public static void IsDividableThree(int number)
        {
            if (number % 3 == 0) Console.WriteLine("This number is dividable by three");
            else Console.WriteLine("This number is not dividable by three");
        }

        public static void IsPrimeNumber(int number)
        {
            bool returnValue = true;

            if (number == 1) returnValue = false;

            if (number == 2) returnValue = true;

           else if (number % 2 == 0) returnValue = false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) returnValue = false;
            }

            if (returnValue) Console.WriteLine("This number is a prime number");
            else Console.WriteLine("This number is not a prime number");

        }

    }
}
