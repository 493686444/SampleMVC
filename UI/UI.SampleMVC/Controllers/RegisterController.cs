using SRV.ProdServices;
using SRV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Controllers
{
    public class RegisterController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            RegisterService service = new RegisterService();
            ViewData["result"] =service.Servicing(model);
            return View();
        }
    }
}