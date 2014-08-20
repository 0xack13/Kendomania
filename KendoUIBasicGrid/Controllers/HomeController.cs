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
            /*ViewBag.Message = "Welcome to ASP.NET MVC!";
            var northwind = new NorthwindEntities2();
            // Get the Products entities and add them in the ViewBag
            ViewBag.Products = northwind.Products;
            return View();
            */
            //var model
            var model = from o in new NorthwindEntities2().Products
                        select new ProductViewModel
                        {
                            ProductID = o.ProductID,
                            ProductName= o.ProductName,
                            SupplierID = o.SupplierID,
                            UnitPrice = o.UnitPrice,
                            QuantityPerUnit = o.QuantityPerUnit,
                            ReorderLevel = o.ReorderLevel,
                            UnitsInStock = o.UnitsInStock,
                            UnitsOnOrder = o.UnitsOnOrder,
                            CategoryID = o.CategoryID,
                            Discontinued = o.Discontinued
                        };
            //var modeProduct = model.ToList();
            ViewBag.Products = model;
            return View();
        }

        public ActionResult Cats()
        {
            var northwind = new NorthwindEntities2();
            ViewBag.Products = northwind.Categories;
            return View();
        }

    }
}
