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
    public class UnvanController : Controller
    {
        // GET: Unvan
        UnvanManager manager = new UnvanManager();
        UnvanModel model = new UnvanModel();
        public ActionResult Unvan()
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
        public ActionResult Ekle(UnvanModel model)
        {
            Unvan unvan = new Unvan();
            unvan.Ad = model.unvan.Ad;
            manager.Ekle(unvan);
            manager.Save();
            return RedirectToAction("Unvan");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            model.unvan = manager.Bul(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncelle(int id, UnvanModel model)
        {
            Unvan unvan = manager.Bul(id);
            unvan.Ad = model.unvan.Ad;
            manager.Guncelle(unvan);
            manager.Save();
            return RedirectToAction("Unvan");
        }
        public ActionResult Detay(int id)
        {
            model.unvan = manager.Bul(id);
            return View(model);

        }
        public ActionResult Sil(int id)
        {
            Unvan unvan = manager.Bul(id);
            manager.Sil(unvan);
            manager.Save();
            return RedirectToAction("Unvan");
        }
    }
}