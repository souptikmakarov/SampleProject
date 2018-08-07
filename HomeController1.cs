using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudValidator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            File.Write("Hello WOrld");
        }

        public ActionResult Admin()
        {
            return View();
            ConfigurationManager.AppSettings["heloo"];
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}