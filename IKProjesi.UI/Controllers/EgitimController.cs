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
    public class EgitimController : Controller
    {
        // GET: Egitim
        EgitimManager manager = new EgitimManager();
        EgitimModel model = new EgitimModel();
        public ActionResult Egitim()
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
        public ActionResult Ekle(EgitimModel model)
        {
            Egitim egitim = new Egitim();
            egitim.Ad = model.egitim.Ad;
            manager.Ekle(egitim);
            manager.Save();
            return RedirectToAction("Egitim");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            model.egitim = manager.Bul(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Guncelle(int id, EgitimModel model)
        {
            Egitim egitim = manager.Bul(id);
            egitim.Ad = model.egitim.Ad;
            manager.Guncelle(egitim);
            manager.Save();
            return RedirectToAction("Egitim");
        }
        public ActionResult Detay(int id)
        {
            model.egitim = manager.Bul(id);
            return View(model);

        }
        public ActionResult Sil(int id)
        {
            Egitim egitim = manager.Bul(id);
            manager.Sil(egitim);
            manager.Save();
            return RedirectToAction("Egitim");
        }
    }
}