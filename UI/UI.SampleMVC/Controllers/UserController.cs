using SRV.ProdServices.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.SampleMVC.Filters;

namespace UI.SampleMVC.Controllers
{
    public class UserController : Controller
    {
        private IndexService service = new IndexService();
        // GET: User
        [NeedLogOn]
        public ActionResult Index()
        {
            int Id = Convert.ToInt32(Request.Cookies["User"]["Id"]);

            SRV.ViewModels.User.IndexModel model = service.Sevicing(Id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SRV.ViewModels.User.IndexModel model)
        {
            service.Sevicing(model);
            return  View();
        }
        public ActionResult RetrievePassword()
        {
            return View();
        }
    }
}