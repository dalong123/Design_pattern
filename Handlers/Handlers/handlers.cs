using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public   class handlers
    {


        private static   handlers handler=new handlers();

        private static object ob = new object();
        public static handlers createfactory()
        {

            lock (ob)
            {
                if (handler != null)
                {

                    return handler;

                }
                else
                {
                    handler = new handlers();
                    return handler;
                }
            
            }
        }
        public   Result Result { get; set; }

           handlers()
        {
            this.Result = new Result() { Message = "init", Name = "init" };
        }
        public   handlers first()
        {
            this.Result.Message = "first method";
            this.Result.Name = "first";
            return  this;
        }
        public   handlers second()
        {
            this.Result.Message = "second method";
            this.Result.Name = "second";
            return this;
        }
        public   handlers third()
        {
            this.Result.Message = "third method";
            this.Result.Name = "third";
            return this;
        }
    }
}
