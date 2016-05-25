using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Example1()
        {
            return View();
        }
    }
}