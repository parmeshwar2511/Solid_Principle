using AutoMapper;
using BAL;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(Configure =>
            Configure.AddProfile<MappingProfile>());

            UnityConfig.RegisterComponents();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // configure log4net
          log4net.Config.XmlConfigurator.Configure();
        }
    }
}
