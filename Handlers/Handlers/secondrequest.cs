using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public class secondrequest:Abrequest
    {

        public secondrequest()
        {
            this.level = 2;
        }
        public override void Request()
        {
            Console.WriteLine("do second request");
        }
    }
}
