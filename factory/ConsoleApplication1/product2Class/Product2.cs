using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IProductClass;

namespace product2Class
{
    class Product2 : IProduct2
    {
        public void doprint()
        {
            Console.WriteLine("Product 2");
        }


        public void init()
        {
            throw new NotImplementedException();
        }
    }
}
