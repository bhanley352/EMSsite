using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClarkEMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stats()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Apply()
        {
            ViewBag.Message = "Application";

            return View();
        }
        public ActionResult Events()
        {
            ViewBag.Message = "Your event photos page.";

            return View();
        }
    }
}