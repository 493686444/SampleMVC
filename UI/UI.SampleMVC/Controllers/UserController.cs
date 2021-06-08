using SRV.ProdServices.User;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(SRV.ViewModels.User.IndexModel model)
        {
            
            if (model.icon != null)
            {
                //起名
                DateTime dateTime = DateTime.Now;
                string folderPath = $@"/Image/{dateTime.Year}/{dateTime.Month}";
                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.icon.FileName)}";
                string filePath = $@"{folderPath}/{fileName}";
                //存文件
                Directory.CreateDirectory(Server.MapPath(folderPath));
                model.icon.SaveAs(Server.MapPath(filePath));
                //修改model
                model.IconPath = filePath;
            }/*else nothing*/

            int Id = Convert.ToInt32(Request.Cookies["User"]["Id"]);
            service.Sevicing(model, Id);
            return RedirectToAction("Index", "User");
        }
        public ActionResult RetrievePassword()
        {
            return View();
        }
    }
}