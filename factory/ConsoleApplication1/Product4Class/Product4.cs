using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IProductClass;

namespace Product4Class
{
    public class Product4 : IProduct2
    {
        public void doprint()
        {
            Console.WriteLine("Product 4");
        }


        public void init()
        {
            throw new NotImplementedException();
        }
    }
}
