using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public class InVoker
    {
        Reciver reciver;
        public InVoker(Reciver reciver)
        {
            this.reciver = reciver;
        }

        public void execute()
        {
            reciver.action();
        }

    }
}
