using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractProduct
{
    public    class AbstractProduct:IProductClass.IProduct2
    {
        public virtual void doprint()
        {
           // Console.WriteLine("Product 5");
        
        }
        public virtual void init()
        {
          //  Console.WriteLine("Product  init 5");
          
        }
        public virtual void setParames()
        {
            //  Console.WriteLine("Product  init 5");

        }
    }
}
