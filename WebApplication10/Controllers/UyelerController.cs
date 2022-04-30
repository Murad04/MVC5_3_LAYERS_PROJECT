using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class UyelerController : Controller
    {
        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities
            ();
        // GET: Uyeler
        public ActionResult Index(string istek, int page = 1)
        {
            var degerler = from t in mvc3KatmanliKUtphaneEntities1.Table_Uyeler select t;
            if (!string.IsNullOrEmpty(istek))
            {
                 degerler = mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Where(uw => uw.AD.Contains(istek)); return View(degerler.ToList().ToPagedList(page,3));
            }
            else
            {
                var degerler2 = mvc3KatmanliKUtphaneEntities1.Table_Uyeler.ToList().ToPagedList(page, 3);
                return View(degerler2);
            }
        }
        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(Table_Uyeler u)
        {

            if (!ModelState.IsValid)
            {
                return View("UyeEkle");
            }
            mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Add(u);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UyeSil(int id)
        {
            var uyr = mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Find(id);
            mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Remove(uyr);
            return RedirectToAction("Index");
        }
        
        public ActionResult UyeGetir(int id)
        {
            var uyre = mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Find(id);
            ViewBag.okulmu = uyre.OKULMU;
            return View("UyeGetir", uyre);
        }
        public ActionResult UyeGuncelle(Table_Uyeler y)
        {
            if (!ModelState.IsValid)
            {
                return View("UyeGetir");
            }
            var uye = mvc3KatmanliKUtphaneEntities1.Table_Uyeler.Find(y.ID);
            uye.AD = y.AD;
            uye.SOYAD = y.SOYAD;
            uye.KULLANICIAD = y.KULLANICIAD;
            uye.SIFRE = y.SIFRE;
            uye.FOTOGRAH = y.FOTOGRAH;
            if (y.OKULMU == true)
            {
                uye.OKULMU = y.OKULMU;
            }
            else
            {
                uye.UNIVERSITEMI = y.UNIVERSITEMI;
            }
            uye.TELEFON = y.TELEFON;
            uye.MAIL = y.MAIL;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}