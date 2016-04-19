﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace LogHelper
{
     public class LogHelper
    {
        /// <summary>
         /// 输出日志到Log4Net
         /// </summary>
         /// <param name="t"></param>
         /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

         public static void WriteErrLog(Type t, Exception ex)
         {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
             log.Error("Error", ex);
         }
 
         #endregion
         
         /// <summary>
         /// 输出日志到Log4Net
         /// </summary>
         /// <param name="t"></param>
         /// <param name="msg"></param>
         #region static void WriteLog(Type t, string msg)
 
         public static void WriteErrLog(Type t, string msg)
         {
             log4net.ILog log = log4net.LogManager.GetLogger(t);
             log.Error(msg);
         }
 
         #endregion

         /// <summary>
         /// 输出日志到Log4Net
         /// </summary>
         /// <param name="t"></param>
         /// <param name="msg"></param>
         #region static void WriteLog(Type t, string msg)

         public static void WriteinfoLog(Type t, string msg)
         {
             log4net.ILog log = log4net.LogManager.GetLogger(t);
             log.Info(msg);
         }

         #endregion
    }
}
