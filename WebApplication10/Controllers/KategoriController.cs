using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class KategoriController : Controller
    {
        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities();
        // GET: Kategori
        public ActionResult Index()
        {
            var deger = mvc3KatmanliKUtphaneEntities1.Table_Kategori.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Table_Kategori p)
        {
            mvc3KatmanliKUtphaneEntities1.Table_Kategori.Add(p);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult KategoriSil(int id)
        {
            var kategori = mvc3KatmanliKUtphaneEntities1.Table_Kategori.Find(id);
            mvc3KatmanliKUtphaneEntities1.Table_Kategori.Remove(kategori);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = mvc3KatmanliKUtphaneEntities1.Table_Kategori.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Table_Kategori k)
        {
            var kt = mvc3KatmanliKUtphaneEntities1.Table_Kategori.Find(k.ID);
            kt.Kategori_Ad = k.Kategori_Ad;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}