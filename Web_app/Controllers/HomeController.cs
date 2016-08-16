using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Web_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ViewResult Proba()
        {

            String s = Servis.DisplayAll();
            return View("Proba", (object)String.Format("wyni: {0}", s));
        }
    }
}
