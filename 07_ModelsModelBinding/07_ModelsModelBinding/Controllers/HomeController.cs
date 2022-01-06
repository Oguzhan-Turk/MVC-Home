using _07_ModelsModelBinding.Models;
using _07_ModelsModelBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_ModelsModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            Person person = new Person();
            person.Name = "Oguzhan";
            person.Surname = "Turk";
            person.Age = 25;

            Address address = new Address();
            address.City = "İstanbul";
            address.AddressDecription = "Ataşehir Kayışdağı";

            homepageViewModel homepagemodel = new homepageViewModel();
            homepagemodel.PersonObject = person;
            homepagemodel.AddressObject = address;

            return View(homepagemodel);
        }
        [HttpPost]
        public ActionResult homepage(homepageViewModel homepagemodel)
        {

            return View(homepagemodel);
        }
    }
}