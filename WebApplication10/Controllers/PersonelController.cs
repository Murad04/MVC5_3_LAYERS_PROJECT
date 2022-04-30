using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class PersonelController : Controller
    {
        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities();
        // GET: Personel
        public ActionResult Index()
        {
            var personeller = mvc3KatmanliKUtphaneEntities1.Table_Personel.ToList();
            return View(personeller);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(Table_Personel p)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelEkle");
            }
            mvc3KatmanliKUtphaneEntities1.Table_Personel.Add(p);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelGetir(int id)
        {
            var personel = mvc3KatmanliKUtphaneEntities1.Table_Personel.Find(id);
            return View("PersonelGetir", personel);
        }
        public ActionResult PersonelGuncelle(Table_Personel p)
        {
            var personel = mvc3KatmanliKUtphaneEntities1.Table_Personel.Find(p.ID);
            personel.PERSONEL = p.PERSONEL;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelSil(int id)
        {
            var personel = mvc3KatmanliKUtphaneEntities1.Table_Personel.Find(id);
            mvc3KatmanliKUtphaneEntities1.Table_Personel.Remove(personel);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}