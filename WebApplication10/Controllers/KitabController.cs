using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models.Entity;
namespace WebApplication10.Controllers
{
    public class KitabController : Controller
    {
        SqlConnection Connection =
              new
              SqlConnection
              (@"Data Source=DESKTOP-8UQUVJ2;Initial Catalog=MVC3KATMANLIDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        MVC3KATMANLIDBEntities mvc3KatmanliKUtphaneEntities1 = new MVC3KATMANLIDBEntities();
        // GET: Kitab
        public ActionResult Index(string istek)
        {
            
            var kitaplar = from t in mvc3KatmanliKUtphaneEntities1.Table_Kitab.ToList()
                           select t;
            if (!string.IsNullOrEmpty(istek))
            {
                kitaplar = kitaplar.Where(i => i.AD.Contains(istek));
            }
            //var kitapler = mvc3KatmanliKUtphaneEntities.Table_KITAB.ToList();
            return View(kitaplar.ToList());
        }
        [HttpGet]
        public ActionResult KitabEkle()
        {
            List<SelectListItem> deger = (from i in mvc3KatmanliKUtphaneEntities1.Table_Kategori.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Kategori_Ad,
                                              Value = i.ID.ToString()
                                          }).ToList();
            ViewBag.dgr1 = deger;
            List<SelectListItem> deger2 = (from i in mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.AD + ' ' + i.SOYAD,
                                               Value = i.ID.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            return View();
        }
        [HttpPost]
        public ActionResult KitabEkle(Table_Kitab kitab)
        {
            var kategoriler = mvc3KatmanliKUtphaneEntities1.Table_Kategori.Where(k => k.ID == kitab.KATEGORI).FirstOrDefault();
            var yazarlar = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Where(y => y.ID == kitab.YAZAR).FirstOrDefault();
            kitab.KATEGORI = kategoriler.ID;
            kitab.YAZAR = yazarlar.ID;
            mvc3KatmanliKUtphaneEntities1.Table_Kitab.Add(kitab);
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitabSil(int id)
        {
            var kitab = mvc3KatmanliKUtphaneEntities1.Table_Kitab.Find(id);
            if ((kitab.KITAB_SAYI - 1) <= 0)
            {
                kitab.KITAB_SAYI = 0;
                kitab.DURUM=false;
            }
            else
            {
                kitab.KITAB_SAYI = kitab.KITAB_SAYI - 1;
                kitab.DURUM = true;
            }
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitabGetir(int id)
        {
            var kitab = mvc3KatmanliKUtphaneEntities1.Table_Kitab.Find(id);
            List<SelectListItem> deger = (from i in mvc3KatmanliKUtphaneEntities1.Table_Kategori.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Kategori_Ad,
                                              Value = i.ID.ToString()
                                          }).ToList();
            ViewBag.dgr1 = deger; List<SelectListItem> deger2 = (from i in mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.ToList()
                                                                 select new SelectListItem
                                                                 {
                                                                     Text = i.AD + ' ' + i.SOYAD,
                                                                     Value = i.ID.ToString()
                                                                 }).ToList();
            ViewBag.dgr2 = deger2;
            return View("KitabGetir", kitab);
        }
        public ActionResult KitabGuncelle(Table_Kitab ki)
        {
            var kitab = mvc3KatmanliKUtphaneEntities1.Table_Kitab.Find(ki.ID);
            kitab.AD = ki.AD;
            kitab.SAYFA_SAYI = ki.SAYFA_SAYI;
            kitab.BASIM_YIL = ki.BASIM_YIL;
            if (ki.KITAB_SAYI == 0)
            {
                kitab.DURUM = false;
            }
            kitab.DURUM = ki.DURUM;
            kitab.YAYIN_EVI = ki.YAYIN_EVI;
            kitab.KITAB_SAYI = ki.KITAB_SAYI;
            var kategori = mvc3KatmanliKUtphaneEntities1.Table_Kategori.Where(k => k.ID == ki.KATEGORI).FirstOrDefault();
            var yazar = mvc3KatmanliKUtphaneEntities1.Tablo_YAZAR.Where(y => y.ID == ki.YAZAR).FirstOrDefault();
            kitab.KATEGORI = kategori.ID;
            kitab.YAZAR =yazar.ID;
            mvc3KatmanliKUtphaneEntities1.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}