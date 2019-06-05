using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HYE_BOX.Models;
using System.Data;
using System.Data.Entity;
using System.Net;
namespace HYE_BOX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private Data_context db = new Data_context();
        public ActionResult Create()
        {
            Trace.WriteLine("GET /Todos/Create");
            return View(new DataModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Description,CreatedDate")] DataModel data)
        {
            Trace.WriteLine("POST /Todos/Create");
            if (ModelState.IsValid)
            {
                db.Data.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}