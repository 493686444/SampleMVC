using SRV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult On()
        {
            return View();
        }
        [HttpPost]
        public ActionResult On(OnModel model)
        {
            return View();
        }
        public ActionResult Off()
        {
            return View();
        }

    }
}