using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
using MVC5_3_LAYERS_PROJECT.Models.Classes;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class VitrinController : Controller
    {
        MVC3KATMANLIDBEntities entities=new MVC3KATMANLIDBEntities();
        [HttpGet]
        // GET: Vitrin
        public ActionResult Index()
        {
            Class1 class1=new Class1();
            class1.KitabDeger=entities.Table_Kitab.ToList();
            class1.HakkimizdaDeger=entities.Table_Hakkimizda.ToList();
            //var degerler = entities.Table_Kitab.ToList();
            return View(class1);
        }
        [HttpPost]
        public ActionResult Index(Table_ILETISIM t)
        {
            entities.Table_ILETISIM.Add(t);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}