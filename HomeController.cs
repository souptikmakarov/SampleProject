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
            Console.WriteLine("Hello");
        }

        public ActionResult Admin()
        {
            return View();
            var config = new ConfigurationBuilder();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}