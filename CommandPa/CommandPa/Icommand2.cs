using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPa
{
    public interface Icommand2
    {
        void execute();
        void before();
        void after();
        void printresult();
         
         
    }
}
