using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoconDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigHOCON config = new ConfigHOCON();
            // config.GetHocon2();

            var info = config.GetHocon3(config.GetConfigKey("third")).GetString("ssh4.network-compression-threshold");


          //  var info2 = config.GetHocon4(config.GetConfigKey("third")).GetString("ssh4.network-compression-threshold");
           
            var info3 = config.GetHocon5(config.GetConfigKey("third")).GetString("ssh4.network-compression-threshold");
          
            Console.ReadLine();
        }
    }
}
