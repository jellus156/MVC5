using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class ViewsController : Controller
    {
        // GET: Views
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult ContentResult()
        {
            return Content("<ROOT><TEXT>123</TEXT></ROOT>", "text/xml", System.Text.Encoding.UTF8);
        }
        public ActionResult File1()
        {
            return File(Server.MapPath("~/App_Data/Koala.jpg"), "image/jpg");
        }
        public ActionResult File2()
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData("https://www.google.com.tw/images/srpr/logo11w.png");
            return File(data, "image/png");
        }
        public ActionResult File3()
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData("https://www.google.com.tw/images/srpr/logo11w.png");
            return File(data, "image/png", "Google.png");
        }
        public ActionResult File4(string url = "https://www.google.com.tw/images/srpr/logo11w.png", string
            flieName = "Google.png")
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            return File(data, "image/png", flieName);
        }
        public ActionResult File5()
        {
            return File(Server.MapPath("~/Content/Yahoo.html"), "text/html");
        }
        public ActionResult File6()
        {
            return File(Server.MapPath("~/Content/Yahoo.html"), "text/plain");
        }
        public ActionResult Json1()
        {
            return Json(new
            {
                id = 1,
                name = "Huang",
                CreatedOn = DateTime.Now,
                Richard = "bai"
            },JsonRequestBehavior.AllowGet);
        }
    }
}