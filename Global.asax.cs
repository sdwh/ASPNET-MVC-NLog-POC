using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NLogFilters
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {

            GlobalFilters.Filters.Add(new NLogFilters.Filters.LogFilter());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();

            logger
                .WithProperty("Property1", "")
                .WithProperty("Property2", "")
                .Info($"Application End");
            NLog.LogManager.Shutdown();
        }
    }
}
