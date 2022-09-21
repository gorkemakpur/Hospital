using Hospital.Business.Repository.Concrete;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        HospitalEntities hospitalEntities = new HospitalEntities();
        TedaviRepository tedaviRepository = new TedaviRepository();
        DoktorRepository doktorRepository = new DoktorRepository();
        BolumRepository bolumRepository = new BolumRepository();

        // GET: Appointment
        [HttpGet]
        public ActionResult Index()
        {
            var bolumler = (from x in hospitalEntities.Bolum.ToList()
                            select new SelectListItem
                            {
                                Text = x.bolumAdi,
                                Value = x.bolumID.ToString()
                            }).ToList();
            ViewBag.d2 = bolumler;

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
        public ActionResult RandevuAl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RandevuAl(Tedavi tedavi)
        {
            var hastaID = Convert.ToInt32(Session["HastaID"]);
          
            tedavi.hastaID = hastaID;


            //var doktor = hospitalEntities.Doktor.Where(x=>x.doktorID == tedavi.Doktor.doktorID).FirstOrDefault();
            //var bolum = hospitalEntities.Bolum.Where(x => x.bolumID == tedavi.Doktor.Bolum.bolumID).FirstOrDefault();
            //var doktorID = Convert.ToInt32(doktor.doktorID);

            //tedavi.doktorID = doktorID;
            //tedavi.Doktor.bolumID = doktor.bolumID;
            //tedavi.Doktor =doktor;
            //tedavi.Doktor.Bolum.bolumID =(bolum.bolumID);

            tedaviRepository.Add(tedavi);
    
            return Redirect("~/Appointment/Index");
        }

    }
}