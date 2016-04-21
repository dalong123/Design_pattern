using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public abstract class abHandler
    {

        public abHandler nexthandler=null;

        public int level = 0;
        public void handlerrequest(Abrequest request)
        {


            if (this.level == request.level)
            {

                this.handler(request);

            }
            else
            {

                if (nexthandler != null)
                {
                    Console.WriteLine("节点不能处理，下一个");
                    nexthandler.handlerrequest(request);

                }
                else
                {
                    Console.WriteLine("不能处理");
                }
            
            }
        
        }
        

        public void SetnextHandler(abHandler handler)
        {

            this.nexthandler = handler;
        }

        public abstract void handler(Abrequest request);



    }
}
