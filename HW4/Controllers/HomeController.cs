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
            ViewBag.Title = "Page 1";
            if (Request.Form["temp"] != null || Request.Form["tempType"] != null)
            {
                string temp = Request.Form["temp"];
                string tempType = Request.Form["tempType"];
                tempType = tempType.ToLower();
                if (Double.TryParse(temp, out double nTemp))
                {
                    if (tempType.Equals("c"))
                    {
                        nTemp = (nTemp - 32) / 1.8;
                        nTemp = Math.Round(nTemp, 2);
                        ViewBag.nTemp = nTemp;

                    }
                    if (tempType.Equals("f"))
                    {
                        nTemp = (nTemp * 1.8) + 32;
                        nTemp = Math.Round(nTemp, 2);
                        ViewBag.nTemp = nTemp;
                    }



                }
            }
            return View();
        }
    }
}