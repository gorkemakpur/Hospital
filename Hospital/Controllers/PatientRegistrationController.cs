using Hospital.Business.Repository.Concrete;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class PatientRegistrationController : Controller
    {
        // GET: PatientRegistration
        HospitalEntities hospitalEntities = new HospitalEntities();
        HastaKayitRepository hastaKayitRepository = new HastaKayitRepository();
        Doktor doktor = new Doktor();
        Bolum bolum = new Bolum();



        public ActionResult Index(HastaKayit hastaKayit)
        {

            var bolumler = (from x in hospitalEntities.Bolum.ToList()
                            select new SelectListItem
                            {
                                Text = x.bolumAdi,
                                Value = x.bolumID.ToString()
                            }).ToList();
            ViewBag.d2 = bolumler;

            //.Where(x => x.bolumID == hastaKayit.bolumID).
 

                    var doktorlar = (from x in hospitalEntities.Doktor.ToList()
                                     select new SelectListItem
                                     {
                                         Text = x.doktorAdi + " " + x.doktorSoyadi,
                                         Value = x.doktorID.ToString()
                                     }).ToList();
                    ViewBag.d1 = doktorlar;
           



            return View();
        }


        [HttpGet]
        public ActionResult RandevuEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RandevuEkle(HastaKayit hastaKayit)
        {
            //Session["bolum"] = hastaKayit.bolumID;
            hastaKayitRepository.Add(hastaKayit);
            return Redirect("Index");
        }
    }
}