using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });
            students.Add(new Student() { RollNbr = 1, FirstName = "One", DOB = DateTime.Now, Class = 1 });

            return View(students);
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {

            ViewBag.Employees = new List<String>() { "AM", "KP", "SM" };
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Student collection)
        {
            try
            {
                ModelState.Remove("RollNbr");
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
               
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Project()
        {
            Project p = new Project();
            p.HasBacklocks = "Y";
            p.SSN = "121211123";
            p.EndDate = DateTime.Now.AddDays(1);
            p.StartDate = DateTime.Now;
            p.ProiectName = "Bat";
            p.ProjectManager = "KP";
            return View(p);
        }

        //
        // POST: /Home/
        [HttpPost]
        public ActionResult Project(Project project)
        {
            if (project.ProiectName == "Snake")
            {
                ModelState.AddModelError("SSN", "Yahooo Error..");
            }
            if (ModelState.IsValid)
            {

            }
            return View(project);
        }
    }
}
