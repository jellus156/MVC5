using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ActionResult Smple1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Smple1(string UserName, string Password, string ConfirmPassword)
        {
            return Content(UserName +"/" + Password +"/"+ ConfirmPassword);
        }
        public ActionResult Smple2()
        {
            return View("Smple1");
        }

        [HttpPost]
        public ActionResult Smple2(FormCollection form)
        {
            return Content(form["UserName"] + "/" + form["Password"] + "/" + form["ConfirmPassword"]);
        }

        public ActionResult Complex1()
        {
            return View("Smple1");
        }

        [HttpPost]
        public ActionResult Complex1(SimpleViewModel item)
        {
            return Content("Complex1:" + item.UserName + "<br />" + item.Password + "/" + item.ConfirmPassword);
        }

        public ActionResult Complex2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Complex2(SimpleViewModel item1, SimpleViewModel item2)
        {
            return Content("Complex1:" + item1.UserName + "/" + item1.Password + "/" + item1.ConfirmPassword + "<br>"
                + item2.UserName + "/" + item2.Password + "/" + item2.ConfirmPassword);
        }

        public ActionResult Complex2ex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Complex2ex(SimpleViewModel item1, SimpleViewModel item2)
        {
            return Content("Complex2:" + item1.UserName + "/" + item1.Password + "/" + item1.ConfirmPassword + "<br>"
                + item2.UserName + "/" + item2.Password + "/" + item2.ConfirmPassword);
        }

        public ActionResult Complex3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Complex3(
            [Bind(Prefix = "item")]
            SimpleViewModel item1)
        {
            return Content("Complex3:" + item1.UserName + "<br />" + item1.Password);
        }

        public ActionResult Complex4()
        {
            var data = from p in db.Client
                       select new SimpleViewModel
                       {
                           UserName = p.FirstName,
                           Password = p.LastName,
                           ConfirmPassword = p.MiddleName
                       };
            return View(data.Take(10));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Complex4(IList<SimpleViewModel> item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Complex4:");
            for (int i = 0; i < item.Count; i++)
            {
                sb.Append(item[i].UserName + "/" + item[i].Password + "/" + item[i].ConfirmPassword);

                if (i < item.Count - 1)
                {
                    sb.Append("<br/>");
                }
            }
            return Content(sb.ToString());
        }
    }
}