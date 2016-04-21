using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abrequest first = new firstrequest();
            //Abrequest second = new secondrequest();
            //Abrequest third = new thirdrequest();
            //abHandler firsthandler = new firstHandler();
            //abHandler secondhandler = new secondHandler();
            //abHandler thirdhandler = new thirdHandler();
            //firsthandler.SetnextHandler(secondhandler);
            //secondhandler.SetnextHandler(thirdhandler);
            //firsthandler.handlerrequest(first);
            //firsthandler.handlerrequest(second);
            //firsthandler.handlerrequest(third);

            var result=  handlers.createfactory().first().second().third();
            Console.WriteLine(string.Format("the name is:{0}.the message is :{1}",result.Result.Name,result.Result.Message));
            Console.ReadLine();

        }
    }
}
