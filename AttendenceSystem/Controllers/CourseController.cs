using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View(new Course().Course_GetAll());
        }
    public ActionResult ASaveEdit()
    {
        return View();
    }
        public ActionResult Save(Course course)
        {
            if(new Course().Course_Save(course) > 0)
            {
                return RedirectToAction("Index", "Course");
            }
            else
            {
                return View();
            }
        }
    }

}