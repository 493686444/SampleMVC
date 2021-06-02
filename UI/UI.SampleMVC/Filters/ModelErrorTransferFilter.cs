using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Filters
{
    public class ModelErrorTransferFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //利用filterContext点儿出来Controller    开箱装箱并且点儿出来ModelState
            ModelStateDictionary modelState = ((Controller)filterContext.Controller).ModelState;
            if (filterContext.HttpContext.Request.HttpMethod == "POST")
            {
                if (!modelState.IsValid)
                {
                    filterContext.Controller.TempData["ErrorInModel"] = modelState;//将modelState装进TempData
                    filterContext.Result =   //重定向
                    new RedirectResult
                    (filterContext.HttpContext.Request.Url.PathAndQuery);
                }
            }
            else if (filterContext.HttpContext.Request.HttpMethod == "GET")
            {
                ModelStateDictionary errors =
                filterContext.Controller.TempData["ErrorInModel"] as ModelStateDictionary;//取出来TempData   并进行开箱装箱
                if (errors != null)
                {
                    modelState.Merge(errors);//信息合并
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}