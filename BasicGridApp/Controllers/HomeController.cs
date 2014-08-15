using BasicGridApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicGridApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person p;
            List<Person> lp = new List<Person>();

            p = new Person();
            p.ID = 1;
            p.FirstName = "Mohammad";
            p.LastName = "Ali";
            lp.Add(p);

            p = new Person();
            p.ID = 2;
            p.FirstName = "Hassan";
            p.LastName = "Omar";
            lp.Add(p);

            p = new Person();
            p.ID = 3;
            p.FirstName = "Ahmed";
            p.LastName = "Yousef";
            lp.Add(p);

            var data = lp;

            return View(data);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
