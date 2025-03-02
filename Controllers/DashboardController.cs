using AcunMedyaHospitalProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaHospitalProject.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {

        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialStatistics()
        {
            ViewBag.DoctorCount = db.Doctors.Count();
            ViewBag.ServiceCount = db.Services.Count();
            ViewBag.AppointmentCount = db.Appointments.Count();
            ViewBag.DepartmentCount = db.Departments.Count();
            return PartialView();
        }
        public ActionResult PartialLastAppointments()
        {
            var values = db.Appointments.OrderByDescending(x => x.CreatedDate).Take(5).ToList();
            return PartialView(values);
        }
        public ActionResult PartialGrapich()
        {

            ViewBag.DoctorCount = db.Doctors.Count();
            ViewBag.ServiceCount = db.Services.Count();
            ViewBag.AppointmentCount = db.Appointments.Count();
            ViewBag.DepartmentCount = db.Departments.Count();
            return PartialView();
        }
    }
}
