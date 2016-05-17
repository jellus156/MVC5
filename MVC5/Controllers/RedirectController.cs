﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Redirect1()
        {
            return RedirectToAction("Index");
        }
        public ActionResult Redirect2()
        {
            return RedirectToActionPermanent("Index");
        }
        public ActionResult Redirect3()
        {
            return Redirect("https://tw.yahoo.com/");
        }
    }
}