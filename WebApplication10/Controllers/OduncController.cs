
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Sql;
using WebApplication10.Models.Entity;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication10.Controllers
{
    public class OduncController : Controller
    {
        SqlConnection Connection =
            new
            SqlConnection
            (@"Data Source=DESKTOP-8UQUVJ2;Initial Catalog=MVC3KATMANLIDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities();
        // GET: Odunc
        public ActionResult Index()
        {
            var data = mvc3KatmanliKUtphaneEntities1.Table_Haraket.Where(x=>x.ISLEMDURUM==false).ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult OduncVer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OduncVer(Table_Haraket hARAKET)
        {
            if (ModelState.IsValid)
            {
                mvc3KatmanliKUtphaneEntities1.Table_Haraket.Add(hARAKET);
                mvc3KatmanliKUtphaneEntities1.SaveChanges();
                return RedirectToAction("/Index/");
            }
            else
            {
                return RedirectToAction("OduncVer");
            }
        }

        public ActionResult Odunciade(int id)
        {
            var odn = mvc3KatmanliKUtphaneEntities1.Table_Haraket.Find(id);
            return View("Odunciade", odn);
        }
        public ActionResult OduncGuncelle(Table_Haraket hr)
        {
            var hrk = mvc3KatmanliKUtphaneEntities1.Table_Haraket.Find(hr.ID);
            hrk.UYEGETIRTARIH = hr.UYEGETIRTARIH;
            hrk.ISLEMDURUM = true ;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("/Index/");
        }
    }
}