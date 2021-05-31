using SRV.ProdServices.Log;
using SRV.ViewModels.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            ViewData["result"]=onService.Servicing(model);
            
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