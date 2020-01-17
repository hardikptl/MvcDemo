using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPerson()
        {
            List<PersonModel> person = new List<PersonModel>();
            person.Add(new PersonModel { FirstName = "hardik", LastName = "patel", Age = 35 });
            person.Add(new PersonModel { FirstName = "hak", LastName = "pel", Age = 35 });
            person.Add(new PersonModel { FirstName = "hdik", LastName = "pal", Age = 35 });

            return View(person);
        }
    }
}