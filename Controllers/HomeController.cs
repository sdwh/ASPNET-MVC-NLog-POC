using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLogFilters.Filters;

namespace NLogFilters.Controllers
{
    [LogFilter]
    public class HomeController : Controller
    {
        private NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}