using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIngleton
{
    public class SingletonClass4
    {

      
        public static class SingletonClass4hoder
        {
            public static SingletonClass4 instanc = new SingletonClass4();
        
        }
         
        private SingletonClass4()
        {


        }
        public String GetUsername()
        {
            return "dalong";
        }
        public String GetUsername2()
        {
            return "dalong2";
        }
        public static SingletonClass4 GetInstance()
        {

            return SingletonClass4hoder.instanc;

        }
    }
}
