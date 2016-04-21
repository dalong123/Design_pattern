using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class Reciver
    {


        public Icommand command { get; set; }

        public Reciver(Icommand command)
        {
            this.command = command;
        }
        public void action() 
        {

            this.command.execute();
        
        }
    }
}
