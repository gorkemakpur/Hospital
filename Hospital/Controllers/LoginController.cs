using Hospital.Business.Repository.Concrete;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class LoginController : Controller
    {
        HospitalEntities hospitalEntities = new HospitalEntities();
        HastaRepository hastarepository = new HastaRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Hasta hasta)
        {
            var contactControl = hospitalEntities.Hasta.FirstOrDefault(x => x.hastaTC == hasta.hastaTC && x.HastaPassword == hasta.HastaPassword);
                //hospitalEntities.Hasta.FirstOrDefault(x => x.hastaTC == hasta.hastaTC && x.HastaPassword == hasta.HastaPassword);
            if(contactControl == null)
            {
                return Content("Kullanıcı Bulunamadı");
            }

            else
            {
                Session["hasta"] = contactControl.hastaAdi +" "+ contactControl.hastaSoyadi; //hasta giriş yaptıktan sonra adı ve soyadını sessionda tutuyorum
                Session["hastaTC"] = contactControl.hastaTC; //tc si işimize yarayabilir diye tc sinide tutuyorum
                Session["hastaID"] = contactControl.hastaID;
                Session["role"] = contactControl.RoleID;
                var role = Session["RoleID"];
                return Redirect("~/Home/Index");
            }
       

        }
        public ActionResult LogOut(Hasta hasta)
        {
            Session.Remove("hasta");
            return Redirect("~/Home/Index");
        }
        public ActionResult Register(Hasta hasta)
        {
            hasta.RoleID = 1;
            hastarepository.Add(hasta);
            return Redirect("~/Login/Index");
        }
    }
}