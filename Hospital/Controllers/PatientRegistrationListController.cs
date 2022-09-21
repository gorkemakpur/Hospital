using Hospital.Business.Repository.Concrete;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class PatientRegistrationListController : Controller
    {
        HospitalEntities hospitalEntities = new HospitalEntities();
        TedaviRepository tedaviRepository = new TedaviRepository();
        HastaKayitRepository hastaKayitRepository = new HastaKayitRepository();     
        Tedavi tedavi = new Tedavi();
        public ActionResult Index()
        {
            List<HastaKayit> patientLists1 = hospitalEntities.HastaKayit.ToList();
            return View(patientLists1);
        }



        public ActionResult RemovePatient(int hastaKayitID)
        {
            hastaKayitRepository.Delete(hastaKayitID);
            List<HastaKayit> patientLists1 = hospitalEntities.HastaKayit.ToList();
            return View("Index", patientLists1);
        }
    }
}