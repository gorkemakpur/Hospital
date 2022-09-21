using Hospital.Business.Repository.Concrete;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class PatientListController : Controller
    {
        // GET: PatientList

        HospitalEntities hospitalEntities = new HospitalEntities();
        TedaviRepository tedaviRepository = new TedaviRepository();
        HastaKayit hastaKayit = new HastaKayit();
        Tedavi tedavi = new Tedavi();
        public ActionResult Index()
        {
            List<Tedavi> patientLists = hospitalEntities.Tedavi.ToList();
            return View(patientLists);
        }



        public ActionResult RemovePatient(int tedaviID)
        {
            tedaviRepository.Delete(tedaviID);
            List<Tedavi> patientLists = hospitalEntities.Tedavi.ToList();
            return View("Index", patientLists);
        }


    }
}