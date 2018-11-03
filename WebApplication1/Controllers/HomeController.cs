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
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Registration";

            return View();
        }

        public ActionResult Call()
        {
            ViewBag.Message = "Call queue number";

            return View();
        }
    }
}