using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Queue()
        {
            ViewBag.Title = "Queue";
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Register";

            return View();
        }

        public ActionResult Call()
        {
            ViewBag.Title = "Call";

            return View();
        }

        [HttpPost]
        public ActionResult RegR()
        {


            return View();
        }

        [HttpPost]
        public ActionResult RegW()
        {
            return View();
        }
    }
}