using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult homepage(string text1, bool check1, string list1)
        {
            var t1 = Request.Form["text1"];
            var l1 = Request.Form["list1"];

            return View();
        }
    }
}