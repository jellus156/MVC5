using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC5.ActionFilter
{
    public class LoggerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string sActionName = filterContext.ActionDescriptor.ActionName;
            string sControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            Trace.TraceInformation(sControllerName + " " + sActionName + " Logger Start!!");
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string sActionName = filterContext.ActionDescriptor.ActionName;
            string sControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            Trace.TraceInformation(sControllerName + " " + sActionName + " Logger End!!");
            base.OnActionExecuted(filterContext);
        }
    }
}
