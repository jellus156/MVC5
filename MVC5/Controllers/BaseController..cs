using MVC5.ActionFilter;
using MVC5.Models;
using System;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    [HandleError(Master = "", ExceptionType = typeof(ArgumentException), View = "ErrorArgument")]
    [HandleError(Master = "", ExceptionType = typeof(OutOfMemoryException), View = "OutOfMemoryException")]
    [Logger]
    public class BaseController : Controller
    {
        public FabricsEntities db = new FabricsEntities();

        protected override void HandleUnknownAction(string actionName)
        {
            if (this.ControllerContext.HttpContext.Request.HttpMethod.ToUpper() == "GET")
            {
                this.View(actionName).ExecuteResult(this.ControllerContext);
            }
            else
            {
                base.HandleUnknownAction(actionName);
            }
        }
    }
}
