using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToastInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["success"] = "Welcome back!";

            TempData["info"] = "Info message";

            TempData["warning"] = "Warning message";

            TempData["error"] = "Error message";

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