using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ko()
        {
            return View();
        }
        public ActionResult Ajax()
        {
            return View();
        }

        public JsonResult People()
        {
            var data = new List<Person>();
            data.Add(new Person { Id = 1, Name = "Name1", DOB = new DateTime() });
            data.Add(new Person { Id = 2, Name = "Name2", DOB = new DateTime() });
            data.Add(new Person { Id = 3, Name = "Name3", DOB = new DateTime() });
            data.Add(new Person { Id = 4, Name = "Name4", DOB = new DateTime() });
            data.Add(new Person { Id = 5, Name = "Name5", DOB = new DateTime() });
            data.Add(new Person { Id = 6, Name = "Name6", DOB = new DateTime() });
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
        }
    }
}