using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product5Class
{
    public class Product5:AbstractProduct.AbstractProduct
    {

        public override void doprint()
        {
          //  base.doprint();

            Console.WriteLine("product 5");
        }

        public override void setParames()
        {
            Console.WriteLine("set product new info ");
        }
    }
}
