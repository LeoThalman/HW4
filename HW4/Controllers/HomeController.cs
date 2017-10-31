using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "The Home Page";
            return View();
        }

        public ActionResult Page1()
        {
            string temp = Request.Form["temp"];
            string tempType = Request.Form["tempType"];

            Debug.WriteLine($"{temp} and {tempType}");
            return View();
        }
    }
}