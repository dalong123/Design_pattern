using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class CommandCon3:Icommand
    {


        Reciver2 reciver;

        public CommandCon3()
        {

        }
        public CommandCon3(Reciver2 reciver)
        {
            this.reciver = reciver;
        }
        public void execute()
        {
            reciver.action(); 
        }
    }
}
