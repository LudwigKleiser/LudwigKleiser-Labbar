using OOP_Labb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb16
{
    interface IProductRepository
    {
        void Add();
        void Get(int id);
        void GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);


    }
}
