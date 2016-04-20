using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGS.Config;
using System.IO;

namespace HoconDemo
{
    public class ConfigHOCON
    {

        public void GetHocon()
        {
            var info = new Configuration(null);
            info.ReadFromString( 
                @"ssh {
                    connection {
                     host:127.0.0.1
                     port:234 
                    }
                    status:on
                    log:[warn,error,info]
                 }");
            var log = info.GetValueList("ssh.log");
            var host = info.GetInt("ssh.connection.host");
        
        }
        public void GetHocon2()
        {
            var info = new Configuration(null);
            Stream str=new FileStream("loginAppconfig.config",FileMode.OpenOrCreate,FileAccess.Read);
            using (str)
            {
                info.ReadFromStream(str);
                var log = info.GetString("ssh.connection.host");
                var host = info.GetValueList("ssh.log");
                var userinfo =  info.GetString("ssh.user");
                var appkey = info.GetString("ssh2.appkey");

            }
           

        }

        public Configuration GetHocon4(string filename)
        {
            var info = new Configuration(null);
            Stream str = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            using (str)
            {
                info.Read(filename);

            }
            return info;

        }

        public Configuration GetHocon5(string filename)
        {
            var info = new Configuration(null);
            var   filenameinfo=  System.AppDomain.CurrentDomain.BaseDirectory+filename;
            info.Read(filenameinfo);
            return info;

        }
        public Configuration GetHocon3(string filename)
        {
            var info = new Configuration(null);
            Stream str = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            using (str)
            {
                info.ReadFromStream(str);

            }
            return info;

        }
        public string GetConfigKey(string name)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(name);

        }
    }
}
