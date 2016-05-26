using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class ViewController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IntArray = new int[] { 1, 2, 3, 4, 5 };
            return PartialView();
        }
        // GET: View
        public ActionResult Example1()
        {
            return View();
        }

        public ActionResult Example3()
        {
            return View();
        }

        public ActionResult Example4()
        {
            return View();
        }

        public ActionResult Example5()
        {
            return View();
        }
    }
}