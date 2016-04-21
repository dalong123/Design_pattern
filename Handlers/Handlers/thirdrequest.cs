using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public class thirdrequest:Abrequest
    {

        public thirdrequest()
        {
            this.level = 3;
        }
        public override void Request()
        {
            Console.WriteLine("do third request");
        }
    }
}
