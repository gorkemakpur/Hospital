using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class AppointmentListController : Controller
    {
        // GET: AppointmentList
        HospitalEntities hospitalEntities = new HospitalEntities();
        public ActionResult Index()
        {
            var patientID = Convert.ToInt32(Session["HastaID"]);
            var userPatientList = hospitalEntities.Tedavi.Where(x=> x.hastaID == patientID).ToList();
            return View(userPatientList);
        }
    }
}