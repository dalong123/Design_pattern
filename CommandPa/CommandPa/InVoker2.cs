using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class InVoker2
    {
        Icommand command;

        Icommand2 command2;
        public InVoker2()
        {

        }

        public InVoker2(Icommand command)
        {
            this.command = command;
        }

        public InVoker2(Icommand2 command)
        {
            this.command2 = command;
        }
        public void  execute()
        {
            command.execute();
        }
        public void execute2()
        {
            command2.execute();
        }
    }
}
