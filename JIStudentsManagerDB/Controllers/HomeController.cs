using JIStudentsManagerDB.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JIStudentsManagerDB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students;

            using (StudentsManagerEntities db = new StudentsManagerEntities())
            {
                students = db.Students.ToList();
            }

            return View(students);
        }
    }
}