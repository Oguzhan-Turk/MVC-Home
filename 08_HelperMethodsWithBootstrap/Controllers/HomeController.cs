using _08_HelperMethodsWithBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_HelperMethodsWithBootstrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message() { Level = 1, Text = "Oguzhan Turk Cankiri" });
            messages.Add(new Message() { Level = 2, Text = "Oguz Turk Kocaeli" });
            messages.Add(new Message() { Level = 3, Text = "Han Turk Ankara" });
            messages.Add(new Message() { Level = 4, Text = "Oguzhan İstanbul" });
            
            return View(messages);
        }
    }
}