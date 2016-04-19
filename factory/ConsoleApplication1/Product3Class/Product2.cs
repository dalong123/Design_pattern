using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IProductClass;

namespace product3Class
{
    class Product3 : IProduct2
    {
        public void doprint()
        {
            Console.WriteLine("Product 3");
        }


        public void init()
        {
            throw new NotImplementedException();
        }
    }
}
