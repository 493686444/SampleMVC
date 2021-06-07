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
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult On(OnModel model)
        {
            OnService onService = new OnService();
            int? userId = onService.Servicing(model, out string result);
            ViewData["result"] = result;

            if (userId == null) 
                return View();

            HttpCookie cookie = new HttpCookie("User");
            cookie.Values.Add("Id", userId.ToString());
            cookie.Values.Add("Name", model.Name);
            cookie.Values.Add("Password", model.Password.MD5Encrypt());
            if (model.RememberMe)
            {
                cookie.Expires = DateTime.Now.AddDays(7);
            }
            Response.Cookies.Add(cookie);

            return View();
        }

        //Off
        public ActionResult Off()
        {
            Response.Cookies["User"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("On", "Log"); //这里用的是URL
        }
        [HttpPost]
        public ActionResult Off(OnModel model)
        {

            return View();
        }


    }
}