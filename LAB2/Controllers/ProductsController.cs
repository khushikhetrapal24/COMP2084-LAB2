using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            string[] product = { "laptop", "tablet", "Desktop" };
            
            ViewData["product"] = product;
            return View();
        }
        public string Details(string detail)
        {
            string message = "You have selected" + @detail;
            return message;
        }
    }
}

