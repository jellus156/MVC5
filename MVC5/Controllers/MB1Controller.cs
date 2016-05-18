using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class MB1Controller : Controller
    {
        private FabricsEntities db = new FabricsEntities();

        // GET: Self
        public ActionResult Index()
        {
            ViewData.Model = db.Product.Find(10);

            ViewData["Product"] = db.Product.Find(121);

            ViewBag.Product2 = db.Product.Find(223);

            return View();
        }

        public ActionResult TempData1()
        {
            ViewData["Messagel"] = "Hello World1";
            TempData["Message2"] = "Hello World2";
            Session["Message3"] = "Hello World3";

            return RedirectToAction("TempData2");
        }

        public ActionResult TempData2()
        {
            ViewData["Messagel"] = ViewData["Messagel"];
            ViewData["Message2"] = TempData["Message2"];
            ViewData["Message3"] = Session["Message3"];

            return View();
        }
    }
}