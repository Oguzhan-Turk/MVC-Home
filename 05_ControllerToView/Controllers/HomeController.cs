using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            //ViewData["text1"] = "Oguzhan Turk";
            //ViewData["check1"] = true; 

            //ViewBag.text1 = "Oguzhan Turkk";
            //ViewBag.check1 = false;

            TempData["text1"] = "Oguzhann Turk";
            TempData["check1"] = true;
            return View();
        }

        public ActionResult about()
        {
            ViewBag.text1 = "Oguzhan Turkk";
            ViewBag.check1 = false;
            
            ViewBag.list1 = 
            new SelectListItem[]
            {
                new SelectListItem() {Text = "Oguzhan"},
                new SelectListItem() {Text = "Ali"},
                new SelectListItem() {Text = "Ahmet"}
            };

            return View();
        }
    }
}