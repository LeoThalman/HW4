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

        /// <summary>
        /// Gets the View for Page1 and loads it
        /// </summary>
        /// <returns>loads Page1.html</returns>
        public ActionResult Page1()
        {
            return View();
        }

        /// <summary>
        /// Checks if the temp is empty, 
        /// parses temp into a double and converts it to Celsius or Fahrenheit depending
        /// on what was entered in tempType, if neither c or f pass an error message
        ///
        /// </summary>
        /// <returns>The new page with the new temperature</returns>
        public ActionResult Page1Text()
        {
        if (Request.Form["temp"] != null && Request.Form["tempType"] != null)
        {
            string temp = Request.Form["temp"];
            string tempType = Request.Form["tempType"];
            ViewBag.Title = "Page 1";
            tempType = tempType.ToLower();
            if (Double.TryParse(temp, out double nTemp))
            {
                if (tempType.Equals("c"))
                {
                    nTemp = (nTemp - 32) / 1.8;
                    nTemp = Math.Round(nTemp, 2);
                    ViewBag.Message = "Your temp is " +  nTemp.ToString();

                }
                else if (tempType.Equals("f"))
                {
                    nTemp = (nTemp * 1.8) + 32;
                    nTemp = Math.Round(nTemp, 2);
                    ViewBag.Message = "Your temp is " + nTemp.ToString();
                }
                else
                {
                        ViewBag.Message = "Invalid Temperature type, please enter C or F";
                }
            }
                else
                {
                    ViewBag.Message = "Please enter a Number";
                }
        }
        return View();
        }
    }
}