﻿using SRV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.SampleMVC.Controllers
{
    public class SupervisionController : Controller  //督促类文体
    {
        //public SqlDbContext context { get; set; }
        // GET: supervision
        public ActionResult Publish()
        {

            return View();
        }
        //[HttpPost]
        //public ActionResult Publish(PublishModel model)
        //{
        //    context = new SqlDbContext();
        //    context.Supervisions.Add(model.Supervision);
        //    context.SaveChanges();
        //    return View();
        //}
    }
}