using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class CommandCon:Icommand
    {
        public void execute()
        {
            Console.WriteLine("do command A");
        }
    }
}
