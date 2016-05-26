using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC5.ActionFilter
{
    public class SharedDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 將原本要顯示的訊息，或執行內容，在此Action執行前先在此執行完畢後再呼叫Action顯示View
            filterContext.Controller.ViewBag.Message = "!!!!! Your application description page.";
            base.OnActionExecuting(filterContext);
        }
    }
}

