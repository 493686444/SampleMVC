using SRV.ProdServices.Log;
using SRV.ViewModels.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Global;

namespace UI.SampleMVC.Controllers
{
    public class LogController : Controller
    {
      //On
        public ActionResult On()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult On(OnModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            OnService onService = new OnService();
        
            bool rememberable = onService.Servicing(model,out string result);
            ViewData["result"] = result;
            if (model.RememberMe&& rememberable)
            {
                HttpCookie cookie = new HttpCookie("User");
                cookie.Values.Add("Name",model.Name);
                cookie.Values.Add("Password",model.Password.MD5Encrypt());
                Response.Cookies.Add(cookie);
            }/*else nothing*/
            return View();
        }

        //Off
        public ActionResult Off()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Off(OnModel model)
        {

            return View();
        }


    }
}