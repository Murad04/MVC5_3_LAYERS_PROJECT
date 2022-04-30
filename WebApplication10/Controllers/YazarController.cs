 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class YazarController : Controller
    {
        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities();
        // GET: Yazar
        public ActionResult Index()
        {
            var degerler = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YazarEkle(Tablo_YAZAR y)
        {
            mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Add(y);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarSil(int id)
        {
            var deger = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Find(id);
            mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Remove(deger);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarGetir(int id)
        {
            var yzr = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Find(id);
            return View("YazarGetir", yzr);
        }
        public ActionResult YazarGuncelle(Tablo_YAZAR p)
        {
            var ya = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Find(p.ID);
            ya.AD = p.AD;
            ya.SOYAD = p.SOYAD;
            ya.DETAY = p.DETAY;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}