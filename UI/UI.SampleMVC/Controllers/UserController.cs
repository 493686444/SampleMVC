﻿using SRV.ProdServices.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //[NeedLogOn]
        public ActionResult Index()
        {
            int Id=Convert.ToInt32(Request.Cookies["User"]["UserId"]);
            string Password=(Request.Cookies["User"]["Password"]).ToString();
            IndexService service = new IndexService();
            SRV.ViewModels.User.IndexModel model= service.Sevicing(Id, Password);
            return View(model);
        }      
        public ActionResult RetrievePassword()
        {

            return View();
        }


    }
}