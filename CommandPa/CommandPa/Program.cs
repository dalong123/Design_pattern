using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Reciver2 reciver=new Reciver2();
            Icommand comd = new CommandCon3(reciver);

            Icommand2 comd2 = new command2Imp(reciver);
            InVoker2 invoker = new InVoker2(comd);
            invoker.execute();
            Console.WriteLine("command1");
            InVoker2 invoker2 = new InVoker2(comd2);
            invoker2.execute2();
            Console.WriteLine("command2");
            
            Console.ReadLine();
        }
    }
}
