using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Filters
{
    public class ContextPerRequest : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var context = HttpContext.Current.Items["context"];
            if (context!=null)
            {
                SRV.ProdServices.Helpers.EndTransaction();
            }
            
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
    }
}