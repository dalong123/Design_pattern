using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    public class firstHandler:abHandler
    {
        public firstHandler()
        {
            this.level = 1;
        }
        public override void handler(Abrequest request)
        {
            request.Request();
             
        }
    }
}
