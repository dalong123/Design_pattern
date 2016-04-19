using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class Factory2
    {
         
    
        public static IProduct  GetProduct(string  parames) {

            IProduct product=null;

            switch (parames)
            {


                case "product":
                    product=new Product();
                    break;

                case "product2":

                    product = new Product2();
                    break;
                default:
                    break;
            }
            return product;
        }
        
    }
}
