using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_3_LAYERS_PROJECT.Models.Entity;
namespace MVC5_3_LAYERS_PROJECT.Controllers
{
    public class IslemController : Controller
    {

        MVC3KATMANLIDBEntities MVC3KATMANLIDBEntities2 = new MVC3KATMANLIDBEntities();
        // GET: Islem
        public ActionResult Index()
        {
            var data = MVC3KATMANLIDBEntities2.Table_Haraket.Where(x => x.ISLEMDURUM == true).ToList();
            return View(data);
        }

        public ActionResult Sentbooks()
        {
            var sentbooks = MVC3KATMANLIDBEntities2.Table_Haraket.Where(x => x.ISLEMDURUM == false).ToList();
            return View(sentbooks);
        }

        public ActionResult Notsendbooks()
        {
            var unsnd = MVC3KATMANLIDBEntities2.Table_Haraket.Where(x => x.ISLEMDURUM == false).ToList();
            return View(unsnd);
        }

    }
}