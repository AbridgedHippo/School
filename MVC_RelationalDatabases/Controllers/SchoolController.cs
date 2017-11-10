using MVC_RelationalDatabases.DataAccess;
using MVC_RelationalDatabases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_RelationalDatabases.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext sc = new SchoolContext();

        // GET: School
        public ActionResult Index()
        {
            return View(sc.Students.ToList());
        }

        public ActionResult Create()
        {
            // ViewBag.Student = new SelectList(sc.Students, "ID", "StudentName");
            ViewBag.ClassId = new SelectList(sc.Classes, "ID", "ClassName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                sc.Students.Add(student);
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public ActionResult Details(int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = sc.Students.Find(ID);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
    }
}