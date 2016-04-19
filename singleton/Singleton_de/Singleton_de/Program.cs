using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_de
{
    class Program
    {
        static void Main(string[] args)
        {
          // var instance = SIngleton.SingletonClass3.GetInstance("SIngleton.SingletonClass3");
           var instance = SIngleton.SingletonClass.GetInstance();
           Console.WriteLine(instance.GetUsername2());
           Console.ReadLine();
        }
    }
}
