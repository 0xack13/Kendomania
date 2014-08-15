using KendoUIBasicGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIBasicGrid.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var northwind = new NorthwindEntities();
            // Get the Products entities and add them in the ViewBag
            ViewBag.Products = northwind.Products;
            return View();
        }

    }
}
