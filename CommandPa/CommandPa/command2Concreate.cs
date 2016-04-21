using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public   class command2Concreate:Icommand2
    {
        public virtual void execute()
        {
            this.before();
            this.after();
            Console.WriteLine("base execute");
        }

        public virtual void before()
        {
            Console.WriteLine("base before");
        }

        public virtual void after()
        {
            Console.WriteLine("base after");
        }

        public virtual void printresult()
        {
            Console.WriteLine("base result");
        }
    }
}
