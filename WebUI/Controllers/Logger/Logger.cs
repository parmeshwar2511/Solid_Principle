using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers.Logger
{
    public class ApplicationDbLogger
    {
       private static readonly ILog log = 
         LogManager.GetLogger(typeof(ApplicationDbLogger));

            public static void Info(string message)
            {   
               log.Info(message);
            }

            public static void Error(string message,Exception ex = null)
            {
                log.Info(message,ex);
            }

            public static void Debug(string message)
            {
                log.Debug(message);
            }

            public static void Warn(string message)
            {
                log.Warn(message);
            }

            public static void Fatal(string message)
            {
                log.Fatal(message);
            }
        

    }
}