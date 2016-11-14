using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb8_VG
{
    class ProductManager
    {
        List<Product> products = new List<Product>
        {
            new Product{Name = "KorvEtt", ID = 1, Price = 900.25F },
            new Product{Name = "KorvTvå", ID = 2, Price = 1050.1F},
            new Product{Name = "KorvTre", ID = 3, Price = 431.1F},
            new Product{Name = "KorvFyra", ID = 4, Price = 1050.1F}

        };

        public delegate void StringConcatinator(string message);
        


        public void FormatProductNameDelegateMethod(int ID, string name, float price)
        {
            Console.WriteLine("{0}. {1} - {2} USD",ID, name, price);
        }

        public delegate void  NumberOperator(string message);
        



        

        public void FormatProductNames(StringConcatinator formattedStrings)
        {
            foreach (var thing in products)
            {
                FormatProductNameDelegateMethod(thing.ID, thing.Name, thing.Price);
            }
        }

        public void PriceCalculation(NumberOperator numberOperator)
        {

        }
    }
}
