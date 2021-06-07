using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Filters
{
    public class NeedLogOn : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int? Id=Helpers.GetUserId();
            if (Id==null)
            {
                filterContext.Result = new RedirectResult("/Log/On");
            }
            else
            {

            }
            base.OnActionExecuting(filterContext);
        }
    }
}