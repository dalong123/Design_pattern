using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public class firstrequest:Abrequest
    {

        public firstrequest()
        {
            this.level = 1;
        }
        public override void Request()
        {

            Console.WriteLine("do first request");
        }
    }
}
