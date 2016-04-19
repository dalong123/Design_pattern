using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = Factory.GetProduct2("Product5Class.Product");
            if (result == null)
            {
                Console.WriteLine("方法执行失败");
            }
            else
            {
                result.doprint();
                result.setParames();
            }
            Console.ReadLine();
           

        }
    }
}
