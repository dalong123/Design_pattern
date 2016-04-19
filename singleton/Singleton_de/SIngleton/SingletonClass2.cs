using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIngleton
{
    public class SingletonClass2
    {

        private volatile static SingletonClass2 instance = new SingletonClass2();

        private SingletonClass2()
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
        public static SingletonClass2 GetInstance()
        {
 
            return instance;

        }
    }
}
