
using IKProjesi.UI.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IKProjesi.BL.BusinessManager;
using static IKProjesi.ENT.Entities;

namespace IKProjesi.UI.Controllers
{
    public class IlController : Controller
    {
        // GET: Il
        IlManager manager = new IlManager();
        IlModel model = new IlModel();
        public ActionResult Il()
        {
            model.list = manager.GenelListe();
            return View(model);

        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(IlModel model)
        {
            Il il = new Il();
            il.IlAd = model.il.IlAd;
            manager.Ekle(il);
            manager.Save();
            return RedirectToAction("Il");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            model.il = manager.Bul(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncelle(int id, IlModel model)
        {
            Il il = manager.Bul(id);
            il.IlAd = model.il.IlAd;
            manager.Guncelle(il);
            manager.Save();
            return RedirectToAction("Il");
        }
        public ActionResult Detay(int id)
        {
            model.il = manager.Bul(id);
            return View(model);

        }
        public ActionResult Sil(int id)
        {
            Il il = manager.Bul(id);
            manager.Sil(il);
            manager.Save();
            return RedirectToAction("Il");
        }
    }
}