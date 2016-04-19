using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIngleton
{
    public class SingletonClass3
    {

        private static Dictionary<string, SingletonClass3> list = new Dictionary<string, SingletonClass3>();

        static SingletonClass3()
        { 
          SingletonClass3 x=new SingletonClass3();
          list.Add(x.GetType().ToString(), x);
          
        }
        public String GetUsername2()
        {
            return "dalong2";
        }
        public static  SingletonClass3 GetInstance(string name)
        {
          var result=  list.Select(item => {

                if (item.Key == name)
                {
                    return item.Value;
                }
                else
                {
                   
                    return null;
                }
            }).FirstOrDefault();
          if (result == null)
          {
              SingletonClass3 x = new SingletonClass3();
              list.Add(x.GetType().ToString() + Guid.NewGuid(), x);
              return x;
          }
          else
          {
              return result;
          }
        
        }


    }
}
