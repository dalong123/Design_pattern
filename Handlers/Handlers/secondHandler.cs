using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    class secondHandler:abHandler
    {

        public secondHandler()
        {
            this.level = 2;
        }
        public override void handler(Abrequest request)
        {
            request.Request();
        }
    }
}
