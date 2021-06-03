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
            //filterContext.IsChildAction   //子action可用  因为我选择了一次action一次连接数据库,所以这个方案放弃了
            var context = HttpContext.Current.Items["context"];
            if (context != null)
            {
                if (filterContext.Exception != null)
                {
                    SRV.ProdServices.Helpers.RollBack();        //回滚
                }
                else
                {
                    SRV.ProdServices.Helpers.EndTransaction(); //结束事务(回滚或者提交)
                }
            }
            else
            {

            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
    }
}