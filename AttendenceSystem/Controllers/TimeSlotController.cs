using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class TimeSlotController : Controller
    {
        // GET: TimeSlot
        public ActionResult Index()
        {
            return View(new TimeSlot().TimeSlot_GetAll());
        }
        public ActionResult Save(TimeSlot timeSlot)
        {
            ViewBag.TSId = new SelectList(new TimeSlot().TimeSlot_GetAll(), "TSId", "TSId");
            if (new TimeSlot().TimeSlot_Save(timeSlot) > 0)
            {
                return RedirectToAction("Index", "TimeSlot");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit(TimeSlot timeSlot)
        {
            if (new TimeSlot().TimeSlot_Update(timeSlot) > 0)
            {
                return RedirectToAction("Index", "TimeSlot");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            if (new TimeSlot().TimeSlot_Delete(id) > 0)
            {
                return RedirectToAction("Index", "TimeSlot");
            }
            else
            {
                return View();
            }
        }
    }
}