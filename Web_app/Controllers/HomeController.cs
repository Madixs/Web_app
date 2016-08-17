using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;

namespace Web_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult User()
        {
            ViewBag.Title = "User Side";
            return View();
        }
        public ActionResult Admin()
        {
            ViewBag.Title = "Admin Side";
            return View();
        }
    }
}
