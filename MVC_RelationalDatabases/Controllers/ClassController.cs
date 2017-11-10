using MVC_RelationalDatabases.DataAccess;
using MVC_RelationalDatabases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RelationalDatabases.Controllers
{
    public class ClassController : Controller
    {
        private SchoolContext sc = new SchoolContext();

        // GET: Class
        public ActionResult Index()
        {
            return View(sc.Teachers.ToList());
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Create()
        {
            // ViewBag.Student = new SelectList(sc.Students, "ID", "StudentName");
            ViewBag.ClassId = new SelectList(sc.Classes, "ID", "ClassName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Class Class)
        {
            if (ModelState.IsValid)
            {
                sc.Classes.Add(Class);
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Class);
        }
    }
}