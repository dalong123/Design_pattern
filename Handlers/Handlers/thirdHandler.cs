using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handlers
{
    class thirdHandler:abHandler
    {

        public thirdHandler()
        {
            this.level = 3;
        }
        public override void handler(Abrequest request)
        {
            request.Request();
        }
    }
}
