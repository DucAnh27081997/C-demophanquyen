using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPhanQuyen.Areas.administration.Help
{
    public class AuthorizeController : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // lay quyen trong co so du lieu

            string[] lstRule = { "Home-Create", "Home-Edit", "Home-Delete","Product-Details","Home-Index", "Customer-Index", "Customer-Details"};
            string nameAction = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "-" + filterContext.ActionDescriptor.ActionName;
            if(!lstRule.Contains(nameAction))
            {
                filterContext.Result = new RedirectResult("~/Admin/Home/Notification");
            }
        }
    }
}