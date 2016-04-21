using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class command2Imp:command2Concreate
    {

         
        Reciver2 reciver;

        public command2Imp()
        {

        }
        public command2Imp(Reciver2 reciver)
        {
            this.reciver = reciver;
        }

        public override void before()
        {
            base.before();

            Console.WriteLine("new object before");
        }

        public override void after()
        {
            base.after();
            Console.WriteLine("new object after");
        }
        public override void execute()
        {
            base.execute();
            Console.WriteLine("执行对象");
        }
    }
}
