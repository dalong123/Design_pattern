using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIngleton
{
    public class SingletonClass
    {

        private volatile static SingletonClass instance = null;
        private static object ob = new object();
        private SingletonClass()
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
        public static SingletonClass GetInstance()
        {
            if (instance == null)
            {
                lock (ob)
                {
                    if (instance == null)
                    {
                        instance = new SingletonClass();
                    
                    }
                }
            }
            return instance;
           
        }
    }
}
