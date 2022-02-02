using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLogFilters.Controllers
{
    public class HomeController : Controller
    {
        private NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            
            logger.WithProperty("Property1", User.Identity.Name).WithProperty("Property2", HttpContext.Request.UserHostAddress).Info($"{User.Identity.Name} Into {ControllerContext.RouteData.Values["action"]} Page");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            logger.WithProperty("Property1", User.Identity.Name).WithProperty("Property2", HttpContext.Request.UserHostAddress).Info($"{User.Identity.Name} Into {ControllerContext.RouteData.Values["action"]} Page");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            logger.WithProperty("Property1", User.Identity.Name).WithProperty("Property2", HttpContext.Request.UserHostAddress).Info($"{User.Identity.Name} Into {ControllerContext.RouteData.Values["action"]} Page");
            return View();
        }
    }
}