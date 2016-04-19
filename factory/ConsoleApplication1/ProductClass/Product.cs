using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IProductClass;

namespace ProductClass
{
    public class Product:IProduct2
    {
        public void doprint()
        {
            Console.WriteLine("Product 1");
        }


        public void init()
        {
            throw new NotImplementedException();
        }
    }
}
